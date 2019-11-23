import { Component } from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'new-borrower',
     template: `<mat-card class="card-container">
     <mat-card-content>
        <mat-form-field>
           <input [(ngModel)]="borrower.Name" matInput placeholder="Borrower Name">
        </mat-form-field>
     <mat-card-actions layout="row" layout-align="end center">
       <button (click)="newBorrower()" md-button class="mat-primary">New Borrower</button>
     </mat-card-actions>
     </mat-card-content>
    </mat-card>`
})
export class NewBorrowerComponent {

    constructor(private webService : WebService) {}

    borrower = {
        Name: ""
    }

    newBorrower() {
        console.log(this.borrower);
      this.webService.addBorrower(this.borrower);
    }
}