import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuizService {

  private url: string = "https://localhost:7213/api/quizzes/";

  constructor(private httpClient: HttpClient) { }

  getQuiz(noChapter: number): Observable<any> {
    return this.httpClient.get(this.url + noChapter);
  }
}
