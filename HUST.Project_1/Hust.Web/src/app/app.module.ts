import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './authenication/login/login.component';
import { appRoutes } from './app.routes';

import { HttpModule } from '@angular/http';


@NgModule({
  declarations: [
<<<<<<< HEAD
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(appRoutes)
=======
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DashboardComponent,
    HeaderComponent,
    SidebarComponent
    
  ],
  imports: [
    BrowserModule,
    HttpModule
>>>>>>> 7b39d0c4769fce2477f1f95cb172c8fe2a757c40
  ],
  providers: [],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule {


}
