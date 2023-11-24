import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login.component';
import { RouterModule, Routes } from '@angular/router';
import { LoginFirstComponent } from './components/login-first/login-first.component';
import { ButtonModule } from 'primeng/button';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { PasswordModule } from 'primeng/password';
import { LoginService } from './components/login-first/shared/login.service';
import { StoreService } from '../dashboard/shared/store.service';

@NgModule({
  declarations: [
    LoginFirstComponent,
    LoginComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: '', component: LoginComponent }]),
    ButtonModule,
    FormsModule,
    InputTextModule,
    PasswordModule,
    ReactiveFormsModule
    // ButtonDemoModule


  ],
  providers: [
    LayoutService
  ]
})
export class LoginModule { }
