import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { StickyNote } from 'src/app/data-types/snote';
import { SnoteService } from 'src/app/services/snote.service';


@Component({
  selector: 'app-snote-page',
  templateUrl: './snote-page.component.html',
  styleUrls: ['./snote-page.component.scss']
})
export class SnotePageComponent implements OnInit {

  snotes : StickyNote[]=[];
  chaptersNumber:number=3;
  
  constructor(private snoteService: SnoteService) { }

  ngOnInit(): void {

    for(let i=0; i<this.chaptersNumber;i++){
      this.snoteService.getStickyNotes(i).subscribe(response =>{
        for(let item of response){
          this.snotes.push(item)
        }
      });
    }
    
  }

}
