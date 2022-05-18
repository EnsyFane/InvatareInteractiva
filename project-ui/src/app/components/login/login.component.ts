import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { LoginUser } from 'src/app/data-types/login-user';
import { LoginService } from 'src/app/services/login.service';
import { PopupComponent } from '../popup/popup.component';

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

  constructor(private formBuilder: FormBuilder, private loginService: LoginService, private dialog: MatDialog, private router: Router) { }


  ngOnInit(): void {
  }

  onSubmit(): void {
    let loginUser: LoginUser = {email: this.form.value.email, password: this.form.value.password};
    this.loginService.login(loginUser).subscribe({
      next: data => {
          if (data === null){
            const dialogConfig = new MatDialogConfig();

            dialogConfig.autoFocus = true;
            dialogConfig.width = '30%';
            dialogConfig.panelClass = 'dialog';
            dialogConfig.data = {title: "Login Error", text: "Invalid credentials!"};
            this.dialog.open(PopupComponent, dialogConfig);
          }
          else {
            sessionStorage.setItem("loggedUser",data);
            this.router.navigate(['home']);
          }
      },
      error: error => {
          console.log('There was an error!'+error.errorMessage);
      }
    });
    this.form.reset();
  }

  register(): void {
    this.router.navigate(['register']);
  }

}
