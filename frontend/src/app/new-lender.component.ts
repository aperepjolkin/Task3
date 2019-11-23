import { Component } from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'new-lender',
     template: `<mat-card class="card-container">
     <mat-card-content>
        <mat-form-field>
           <input [(ngModel)]="lender.Name" matInput placeholder="Lender Name">
        </mat-form-field>
     <mat-card-actions layout="row" layout-align="end center">
       <button (click)="newLender()" md-button class="mat-primary">New Lender</button>
     </mat-card-actions>
     </mat-card-content>
    </mat-card>`
})
export class NewLenderComponent {

    constructor(private webService : WebService) {}

    lender = {
        Name: ""
    }

    newLender() {
        console.log(this.lender);
      this.webService.addLender(this.lender);
    }
}