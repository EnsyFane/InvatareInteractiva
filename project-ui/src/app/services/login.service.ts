import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginUser } from '../data-types/login-user';
import { User } from '../data-types/user';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private url: string = "https://localhost:7213/api/users/login";

  constructor(private httpClient: HttpClient) { }

  login(loginUser: LoginUser): Observable<any> {
    return this.httpClient.post(this.url, loginUser);
  }
}
