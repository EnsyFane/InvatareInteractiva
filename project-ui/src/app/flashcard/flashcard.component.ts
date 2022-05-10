import { Component, OnInit } from '@angular/core';
import { Flashcard } from '../data-types/flashcard';

@Component({
  selector: 'app-flashcard',
  templateUrl: './flashcard.component.html',
  styleUrls: ['./flashcard.component.scss']
})
export class FlashcardComponent implements OnInit {

  flashcard: Flashcard = {
     id: 0,
     title:"Title of the flashcard", 
     text:"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.", 
     quizzId:0
    };

  constructor() { }

  ngOnInit(): void {
  }

}
