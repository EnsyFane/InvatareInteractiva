import { Component, Input, OnInit } from '@angular/core';
import { Chapter } from 'src/app/data-types/chapter';

@Component({
  selector: 'app-chapter',
  templateUrl: './chapter.component.html',
  styleUrls: ['./chapter.component.scss']
})
export class ChapterComponent implements OnInit {

  @Input() chapter!:Chapter;
  
  constructor() { }

  ngOnInit(): void {
  }
}
