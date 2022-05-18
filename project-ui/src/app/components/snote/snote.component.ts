import { Component, Input, OnInit } from '@angular/core';
import { StickyNote } from 'src/app/data-types/snote';

@Component({
  selector: 'app-snote',
  templateUrl: './snote.component.html',
  styleUrls: ['./snote.component.scss']
})
export class SnoteComponent implements OnInit {
  
  @Input() snote!:StickyNote;
  constructor() { }

  ngOnInit(): void {
  }

}
