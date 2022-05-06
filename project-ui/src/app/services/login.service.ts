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

  login(loginUser: LoginUser): void {
    this.httpClient.post(this.url, {email: loginUser.email, password: loginUser.password}).subscribe({
      next: data => {
          console.log(data);
      },
      error: error => {
          console.log('There was an error!'+error.errorMessage);
      }
  });
  }
}
