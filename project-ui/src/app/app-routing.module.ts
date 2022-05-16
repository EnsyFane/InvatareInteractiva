import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChapterPageComponent } from './components/chapter-page/chapter-page.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { QuizComponent } from './components/quiz/quiz.component';

export const routes: Routes = [{
  path: '',
  redirectTo: '/login',
  pathMatch: 'full'
}, {
  path: 'login',
  component: LoginComponent
}, {
  path: 'home',
  component: HomeComponent
}, {
  path: 'knowledge',
  //TODO add each component for it's specific route, also don't forget to
  // add the generic header component to each one of them
  component: ChapterPageComponent
}, {
  path: 'quizzes',
    component: QuizComponent
}, {
  path: 'flashcards',
    component: HomeComponent
}, {
  path: 'notes',
    component: HomeComponent
}, {
  path: 'leaderboards',
    component: HomeComponent
}, {
  path: 'friends',
    component: HomeComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
