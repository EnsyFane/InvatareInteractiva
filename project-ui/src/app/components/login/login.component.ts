import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { LoginUser } from 'src/app/data-types/login-user';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  form = this.formBuilder.group({
    email: ['', Validators.required],
    password: ['', Validators.required]
  })

  error: boolean = false;

  errorMessage: string = " ";

  constructor(private formBuilder: FormBuilder, private loginService: LoginService) { }


  ngOnInit(): void {
  }

  onSubmit(): void {
    let loginUser: LoginUser = {email: this.form.value.email, password: this.form.value.password};
    // console.log(loginUser);
    this.loginService.login(loginUser);
  }

}
