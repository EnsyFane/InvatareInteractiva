import { Component, OnInit } from '@angular/core';
import { Flashcard } from 'src/app/data-types/flashcard';

@Component({
  selector: 'app-flashcard-page',
  templateUrl: './flashcard-page.component.html',
  styleUrls: ['./flashcard-page.component.scss']
})
export class FlashcardPageComponent implements OnInit {

  flashcard: Flashcard = {
    title:"Leadership-ul orientat spre cunoștințe", 
    text:"Abilitatea dinamică focusată pe reconfigurarea continuă a cunoștințelor tacite și explicite ale unei organizații ", 
   };

   flashcard1: Flashcard = {
    title:"Cunoștințele", 
    text:"O înțelegere a informațiilor și a pattern-urilor de asociere dintre ele. Pot să fie atât tacite (a știi „cum”), cât și explicite (a știi „ce”) ", 
   };

   flashcard2: Flashcard = {
    title:"Managementul cunoștințelor ", 
    text:"un proces formal și direcționat care are ca și scopuri determinarea informațiilor pe care o companie le deține și construirea de modalități prin care informațiile să devină accesibile tuturor membrilor organizației", 
   };


   flashcards: any =[];
   totalLength!: number;
   p:number=0;

  constructor() { }

  ngOnInit(): void {
    this.flashcards.push(this.flashcard);
    this.flashcards.push(this.flashcard1);
    this.flashcards.push(this.flashcard2);

    this.totalLength = this.flashcards.length;
  }

}
