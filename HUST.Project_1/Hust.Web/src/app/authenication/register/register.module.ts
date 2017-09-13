import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router'
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register.component';

export const routes: Routes = [
  //login/323
  { path: 'register', component: RegisterComponent, pathMatch:'full' }
];

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [RegisterComponent]
})
export class RegisterModule { }
