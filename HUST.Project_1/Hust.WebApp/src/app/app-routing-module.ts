import { EmailComponent } from './email/email.component';
import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import{AuthenticationComponent} from './authentication/authentication.component';
import{DashboardComponent} from './dashboard/dashboard.component';

const routes:Routes=[
    {path:'',redirectTo:'/login', pathMatch:'full'},
    {path:'login', component:AuthenticationComponent},
    {path:'dashboard', component:DashboardComponent},
    {path:'email', component:EmailComponent, outlet:'email1'} 
];
@NgModule({
imports:[RouterModule.forRoot(routes)],
exports:[RouterModule]
})
export class AppRoutingModule{}