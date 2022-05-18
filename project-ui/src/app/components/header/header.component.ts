import { Component } from '@angular/core';

@Component({
  selector: 'header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  headerButtons: Tabs[] = [{
    name: 'Gain Knowledge',
    link: '/knowledge'
  }, {
    name: 'Quizzes',
    link: '/quizzes'
  }, {
    name: 'Flashcards',
    link: '/flashcards'
  }, {
    name: 'Sticky Notes',
    link: '/notes'
  }]
}

export interface Tabs {
  name: string;
  link: string;
}
