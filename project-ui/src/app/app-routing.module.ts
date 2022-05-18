import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChapterPageComponent } from './components/chapter-page/chapter-page.component';
import { FlashcardPageComponent } from './components/flashcard-page/flashcard-page.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { QuizComponent } from './components/quiz/quiz.component';
<<<<<<< HEAD
import { SnotePageComponent } from './components/snote-page/snote-page.component';
=======
import { RegisterComponent } from './components/register/register.component';
>>>>>>> 9a5268521c0f8a03951dea6149cadd8794958ec6

export const routes: Routes = [{
  path: '',
  redirectTo: '/login',
  pathMatch: 'full'
}, {
  path: 'login',
  component: LoginComponent
}, {
  path: 'register',
  component: RegisterComponent
},{
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
    component: FlashcardPageComponent
}, {
  path: 'notes',
    component: SnotePageComponent
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
