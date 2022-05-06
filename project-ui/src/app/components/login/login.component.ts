import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

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

  constructor(private formBuilder: FormBuilder) { }


  ngOnInit(): void {
  }

  onSubmit(): void {}

}
