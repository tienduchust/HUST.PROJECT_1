import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { AuthenticationComponent } from './authentication/authentication.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing-module';
import { EmailComponent } from './email/email.component';
import {CommonService} from './common.service';
@NgModule({
  declarations: [
    AppComponent,
    AuthenticationComponent,
    SidebarComponent,
    DashboardComponent,
    EmailComponent   
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  //   RouterModule.forRoot([
  //     {
  //       path: 'hustDashBoard',
  //       component: DashboardComponent
  //     }
  //   ])
  ],
  providers: [CommonService],
  bootstrap: [AppComponent]
})
export class AppModule { }
