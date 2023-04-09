import { inject } from "@angular/core";
import { AccountService } from "../_services/account.service";
import { map } from "rxjs/internal/operators/map";
import { Router } from "@angular/router";
import { ToastrService } from "ngx-toastr";

/*import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';

import { inject } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';
import { map } from 'rxjs/internal/operators/map';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard {
  constructor(private accountService: AccountService, private toast:ToastrService) {}

  canActivate(): Observable<boolean> {
    return this.accountService.currentUser$.pipe(
      map(
        (user: any) => {
         return true;
          }
        
      )
    )
  }
}

export const authGuardFn = () => {
  return (inject(AuthGuard).canActivate.bind(inject(AuthGuard)));
}
*/
export const authGuardFn = () => {
  const accountService = inject(AccountService);
  const router = inject(Router);
  const toastr = inject(ToastrService);
  return accountService.currentUser$.pipe(
    map(
      (user: any) => {
       if(user) return true;
       else {
        toastr.error('You shall not pass');
        return false;
       }
        }
      
    )
  ) 
}