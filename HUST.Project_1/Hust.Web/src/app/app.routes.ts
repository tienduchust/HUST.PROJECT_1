import { Routes } from "@angular/router";

export const appRoutes: Routes = [
  // { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', loadChildren: './authenication/login/login.module#LoginModule' },
  { path: 'register', loadChildren: './authenication/register/register.module#RegisterModule' }
]
