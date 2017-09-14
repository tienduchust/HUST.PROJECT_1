import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/RX';
import { RequestOptions, Request, RequestMethod, Headers } from '@angular/http';

@Injectable()
export class ApiService {

  constructor(private http: Http) { }

  _get(url) {
    console.log('Start Get');
    if (!url) {
      return 'Url is null';
    }
    const myHeaders = new Headers({ 'Content-Type': 'application/json' });

    const options = new RequestOptions({
      method: 'GET',
      url: url,
      headers: myHeaders
    });
    this.http.get(url)
      .toPromise()
      .then(
        res => console.log(res.json()),
        msg => console.error(`Error: ${msg.status} ${msg.statusText}`)
      );
  }

}
