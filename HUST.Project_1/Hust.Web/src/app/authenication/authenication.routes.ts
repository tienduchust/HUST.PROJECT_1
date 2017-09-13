import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AuthenicationComponent } from './authenication.component';

export const authenicationRoutes: Routes = [
  {
    path: '',
    component: AuthenicationComponent,
    children: [
      {
        path: '',
        pathMatch: 'full',
        component: LoginComponent
      },
      {
        path: ':id',
        component: RegisterComponent
      }
    ]
  }

]
debugger;
