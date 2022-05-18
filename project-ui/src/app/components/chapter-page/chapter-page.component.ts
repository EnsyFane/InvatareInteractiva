import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Chapter } from 'src/app/data-types/chapter';
import { StickyNote } from 'src/app/data-types/snote';
import { SnoteService } from 'src/app/services/snote.service';
import { PopupComponent } from '../popup/popup.component';
import {Location} from '@angular/common';

@Component({
  selector: 'app-chapter-page',
  templateUrl: './chapter-page.component.html',
  styleUrls: ['./chapter-page.component.scss']
})

export class ChapterPageComponent implements OnInit {

  chapter: Chapter = {
    id: 1,
    title:"Definiții", 
    text:"Leadership-ul poate fi definit în termeni de metode intenționate pe care un lider le folosește pentru a influența un grup de oameni dintr-o organizație, în vederea atingerii unei stări viitoare a organizației, stare înțeleasă de întregul grup influențat și care e diferită de poziția din prezent a organizației. (Gandolfi & Stone, 2016) Motivul pentru care leadership-ul este un element important al unei organizații îl reprezintă rezultatele negative pe care un leadership ineficient, toxic sau absent îl are asupra oamenilor, organizației, comunității sau chiar asupra unor întregi societăți, printre aceste outcome-uri negative numărându-se pierderi financiare la nivel de organizație, părăsirea locului de muncă de către angajați sau chiar închiderea organizației, liderul având sarcina de a contura traseul întregii organizații, astfel, un leadership nepotrivit ducând organizația pe un drum nepotrivit, care îi este dăunător. În ceea ce privește eficiența leadership-ului, autorii au conturat cinci atribute cheie care definesc un leadership eficient, aceste atribute sunt modelarea, de către lider, a căii pe care va merge organizația, să contureze o viziune comună asupra organizației, scopurilor și obiectivelor acesteia, să aducă provocări în procesul de muncă, să le permită celorlalți să acționeze și să încurajeze inima și munca din plăcere. Aceste atribute întrunite ducând spre catalogarea unui lider ca fiind eficient. (Gandolfi & Stone, 2018)", 
   };
   chapter1: Chapter = {
    id: 2,
    title:"Teorii", 
    text:"Teoria leadershipului tranzacțional se bazează pe ideea de reciprocitate, unde nu doar liderii influențează membrii grupului, ci și acești membri influențează liderul. (Nawaz et al., 2016) Teoria leadershipului transformațional are în vedere un bine superior, liderii având rolul de a implica membrii grupului condus în activități sau procese relaționate cu factori personali față de organizație și un parcurs care va produce anumite dividente sociale, aceștia crescând motivația și moralul atât membrilor grupului, cât și liderului, focusul fiind pe conducerea prin exemplu. (Nawaz et al., 2016)",
   };
   chapter2: Chapter = {
    id: 3,
    title:"Stiluri de leadership", 
    text:"Conform lui Goleman există 6 stiluri de leadership: coercitiv, autoritativ, afiliativ, democratic, pacesetting și coaching. Liderii coercitivi și pacesetting sunt orientați spre excelență și atingerea unei performanțe înalte, diferența dintre ei este că liderii coercitivi au un auto-control ridicat, iar liderii pacesetting au nivel ridicat de conștiinciozitate. Liderii autoritativi sunt încrezători în ei și abilitățile proprii, având totodată și empatie față de ceilalți, fiind orientați spre schimbare și inovație, liderii coaching susțin dezvoltarea abilităților celorlalți prin feedback și ghidare, iar liderii afiliativi sunt empatici și atenți la emoțiile celorlalți, susținând crearea de relații în cadrul echipei. Liderii democratici sunt atenți la dorința membrilor de a participa și la implicarea voită a acestora prin încurajarea integrării inputului fiecărui membru. (Goleman, 2017)", 
   };

   chapters: any =[];
   totalLength!: number;
   addState:boolean=false;
   p:number=0;
   noChapter = 1;

   form = this.formBuilder.group({
    text: ['', Validators.required],
    noChapter: ['', Validators.required]
  })

  goToQuizzPage(){
    this.location.replaceState("/quizzes/" + this.noChapter);
    document.location.href = "/quizzes/" + this.noChapter;
  }

  pageChange(pageNumber: any){
    this.noChapter = pageNumber;
  }

  onSubmit(){
    let stickyNoteForm : StickyNote ={text: this.form.value.text, noChapter: this.form.value.noChapter};

    this.snoteService.addStickyNote(stickyNoteForm).subscribe({
      next: data => {
          if (data === null){
            const dialogConfig = new MatDialogConfig();
            dialogConfig.autoFocus = true;
            dialogConfig.width = '30%';
            dialogConfig.panelClass = 'dialog';
            dialogConfig.data = {title: "Add Error", text: "Invalid credentials!"};
            this.dialog.open(PopupComponent, dialogConfig);
          }
          else{
            this.addState=!this.addState;
          }
      },
      error: error => {
          console.log('There was an error!'+error.errorMessage);
      }
    });
    this.form.reset();
    
  }


  onAddClick(){
    this.addState=!this.addState;
  }

  constructor(private formBuilder: FormBuilder, private snoteService:SnoteService, private dialog: MatDialog, private location: Location) { }

  ngOnInit(): void {
    this.chapters.push(this.chapter);
    this.chapters.push(this.chapter1);
    this.chapters.push(this.chapter2);

    this.totalLength = this.chapters.length;
  }

}
