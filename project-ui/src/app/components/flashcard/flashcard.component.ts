import { Component, Input, OnInit } from '@angular/core';
import { Flashcard } from 'src/app/data-types/flashcard';

@Component({
  selector: 'app-flashcard',
  templateUrl: './flashcard.component.html',
  styleUrls: ['./flashcard.component.scss']
})
export class FlashcardComponent implements OnInit {

  @Input() flashcard!: Flashcard;
  constructor() { }

  ngOnInit(): void {
  }

}
