import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthenicationComponent } from './authenication.component';
import { authenicationRoutes } from './authenication.routes';
import { RouterModule, Routes } from '@angular/router';
import { LoginModule } from './login/login.module'
import { RegisterModule } from './register/register.module';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component'

@NgModule({
  imports: [
    CommonModule,
    LoginModule,
    RegisterModule,
    RouterModule.forChild(authenicationRoutes)
  ],
  declarations: [
    AuthenicationComponent,
    LoginComponent,
    RegisterComponent
  ],
  providers: []
})
export class AuthenicationModule {

}
