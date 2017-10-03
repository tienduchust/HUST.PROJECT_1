import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
@Injectable()
export class CommonService {

  constructor(private router: Router) { }

  goState(state) {
    this.router.navigate([state]);
  }
}
