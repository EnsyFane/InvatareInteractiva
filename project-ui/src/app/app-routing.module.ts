import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { QuizzesComponent } from './components/quizzes/quizzes.component';

export const routes: Routes = [{
  path: '',
  redirectTo: '/home',
  pathMatch: 'full'
}, {
  path: 'home',
  component: HomeComponent
}, {
  path: 'knowledge',
  //TODO add each component for it's specific route, also don't forget to
  // add the generic header component to each one of them
  component: HomeComponent
}, {
  path: 'quizzes',
    component: QuizzesComponent
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
