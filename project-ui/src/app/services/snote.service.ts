import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { StickyNote } from '../data-types/snote';

@Injectable({
  providedIn: 'root'
})
export class SnoteService {

  constructor(private httpClient: HttpClient) { }

  getStickyNotes(noChapter: number): Observable<StickyNote[]>{
    let url:string="https://localhost:7213/api/stickynotes/";
    url+=noChapter.toString();
    console.log(url)
    return this.httpClient.get<StickyNote[]>(url);
    
  }

  addStickyNote(stickyNote:StickyNote): Observable<any>{
    let url:string="https://localhost:7213/api/stickynotes/";
    return this.httpClient.post(url,stickyNote);
  }
}
