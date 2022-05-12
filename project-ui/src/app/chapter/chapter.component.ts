import { Component, OnInit } from '@angular/core';
import { Chapter } from '../data-types/chapter';

@Component({
  selector: 'app-chapter',
  templateUrl: './chapter.component.html',
  styleUrls: ['./chapter.component.scss']
})
export class ChapterComponent implements OnInit {

  chapter: Chapter = {
     id: 0,
     title:"Title of the chapter", 
     text:"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam aliquam aliquam diam, a volutpat odio consectetur id. Vivamus ut nunc vitae quam blandit pharetra. Suspendisse malesuada, arcu nec sollicitudin placerat, nulla nisi commodo enim, sit amet cursus justo arcu vitae ipsum. Integer nunc nibh, fringilla vitae enim at, auctor aliquam ex. Proin sed metus felis. Cras congue congue leo, ac lacinia leo imperdiet at. Nunc justo elit, dignissim a nisl nec, tincidunt hendrerit nulla. Integer placerat nisi ac risus ornare, non ultricies enim imperdiet.", 
    };

  constructor() { }

  ngOnInit(): void {
  }
}
