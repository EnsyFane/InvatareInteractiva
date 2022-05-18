import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegisterUser } from '../data-types/register-user';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  private url: string = "https://localhost:7213/api/users/register";

  constructor(private httpClient: HttpClient) { }

  register(registerUser: RegisterUser): Observable<any> {
    return this.httpClient.post(this.url, registerUser);
  }
}
