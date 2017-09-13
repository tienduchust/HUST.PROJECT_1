import { Component } from '@angular/core';
import { Http,Response } from '@angular/http';
import 'rxjs/add/operator/map';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  private url = 'http://localhost:8888/api/values';
  data:any={};
  /**
   *
   */
  constructor( private http:Http) {
    console.log('Start');
    this.getCotacts();
    this.getData();
  }

  getData(){
    return this.http.get(this.url).map((res:Response)=>res.json());
  }
  getCotacts(){
    this.getData().subscribe(data=>{
      console.log(data);
      this.data = data;
    });
  }
}
