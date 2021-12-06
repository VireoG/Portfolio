import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';
import { RegisterService } from '../../services/register.service';
import { RegisterUser } from './RegisterUser';
import { AuthUser } from './AuthUser';
import { KeyValueDTO } from './KeyValueDTO';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  providers: [AuthService],
  styleUrls: ['./auth.component.scss']
})

export class AuthComponent implements OnInit {
  authUser: AuthUser = {} as AuthUser;
  registerUser: RegisterUser = {} as RegisterUser;
  isAuth: boolean = true;
  isClient: boolean = true;
  types: Array<KeyValueDTO> = [
    {key: 0, value: 'Client'},
    {key: 1, value: 'Realtor'}
  ];
  registerForm!: FormGroup;

  constructor(private authService: AuthService,
              private registerService: RegisterService,
              private router: Router, private fb: FormBuilder) {
  }

  ngOnInit(): void {
    this.registerForm = this.fb.group({
      firstName: ['', Validators.required],
      middleName: ['', Validators.required],
      lastName: ['', Validators.required],
      age: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
      phone: ['', Validators.required],
      percent: ['', Validators.required],
      passport: ['', Validators.required],
      selectType: [ -1, Validators.required],
    });
  }

  authenticate(): void {
    if (this.authUser.password !== null &&
      this.authUser.email !== null) {
      this.authService.authenticate(this.authUser).subscribe(authResponse => {
        localStorage.setItem('token', authResponse.token);
        console.log(localStorage);
        console.log(localStorage.getItem('token'));
        this.router.navigate(['/orders']);
      });
    }

    var token = localStorage.getItem('token');
    if(token !== null) {     
      this.authService.validate(token).subscribe(user => {
        localStorage.setItem('userId', user.id.toString());
        console.log(user.id.toString());
      });
    }
  }

  register(): void {
    this.fillUser();

    if (this.registerUser.password !== null && 
        this.registerUser.firstName !== null && 
        this.registerUser.email !== null && 
        this.registerUser.age !== null && 
        this.registerUser.phone !== null && 
        this.registerUser.lastName !== null && 
        this.registerUser.middleName !== null &&
        this.registerUser.type !== null) {

      if(this.registerUser.type == "Client" && this.registerUser.passport !== null) {
        this.registerUser.type = "CLIENT";
      }else if(this.registerUser.type == "Realtor" && this.registerUser.passport !== null){
        this.registerUser.type = "REALTOR";
      }

      this.registerService.register(this.registerUser).subscribe(s => {
        console.log(s);
        this.router.navigate(['/auth']);
      });                 
    }   
  }

   fillUser(){
    this.registerUser.password = this.registerForm.value.password;
    this.registerUser.firstName = this.registerForm.value.firstName;
    this.registerUser.email = this.registerForm.value.email;
    this.registerUser.age = this.registerForm.value.age;
    this.registerUser.phone = this.registerForm.value.phone;
    this.registerUser.lastName = this.registerForm.value.lastName;
    this.registerUser.middleName = this.registerForm.value.middleName;
    this.registerUser.type = this.registerForm.value.selectType;
    this.registerUser.percent = this.registerForm.value.percent;
    this.registerUser.passport = this.registerForm.value.passport;
  }

  showFormAuth(): void {
    this.isAuth = true;

  }

  showFormReg(): void {
    this.isAuth = false;
  }

  dropDownChange(e : any) {
    this.registerForm.value.selectType = this.types[e.target.value].value;

    if(e.target.value == 0) {   
      this.isClient = true;
    }else if(e.target.value == 1) {
      this.isClient = false;
    }
  }
}
