import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { RegisterUser } from 'src/app/data-types/register-user';
import { RegisterService } from 'src/app/services/register.service';
import { PopupComponent } from '../popup/popup.component';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  form = this.formBuilder.group({
    email: ['', Validators.required],
    password: ['', Validators.required],
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    role: ['', Validators.required],
    nickName: ['', Validators.required],
  })

  error: boolean = false;

  errorMessage: string = " ";

  constructor(private formBuilder: FormBuilder, private registerService: RegisterService, private dialog: MatDialog, private router: Router) { }


  ngOnInit(): void {
  }

  onSubmit(): void {
    let registerUser: RegisterUser = {firstName: this.form.value.firstName, lastName: this.form.value.lastName, email: this.form.value.email, password: this.form.value.password, role: this.form.value.role, nickName: this.form.value.nickName};
    this.registerService.register(registerUser).subscribe({
      next: data => {
          if (data === null){
            const dialogConfig = new MatDialogConfig();

            dialogConfig.autoFocus = true;
            dialogConfig.width = '30%';
            dialogConfig.panelClass = 'dialog';
            dialogConfig.data = {title: "Register Error", text: "A user with this email already exists!"};
            this.dialog.open(PopupComponent, dialogConfig);
          }
          else {
            this.router.navigate(['home']);
          }
      },
      error: error => {
          console.log('There was an error!'+error.errorMessage);
      }
    });
    this.form.reset();
  }

  onLogin(): void{
    this.router.navigate(['login']);
  }

}
