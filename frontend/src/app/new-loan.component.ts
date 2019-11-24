import { Component} from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'new-loan',
     template: `<mat-card class="card-container">
     <mat-card-content>
        <mat-form-field>
        <mat-select [ngModel]="selectedBorrower" (ngModelChange)="onChange($event)" (click)="getBorrowersList()">
            <mat-option *ngFor="let borrower of borrowersList" [value]="borrower.id">
              {{borrower.name}}
            </mat-option>
        </mat-select>
        </mat-form-field>
        <mat-form-field>
        <mat-select [ngModel]="selectedLender" (ngModelChange)="onLenderChange($event)" (click)="getLendersList()">
            <mat-option *ngFor="let lender of lendersList" [value]="lender.id">
              {{lender.name}}
            </mat-option>
        </mat-select>

        </mat-form-field>
        <mat-form-field>
            <input [(ngModel)]="loan.LoanBalance" matInput placeholder="Loan">
        </mat-form-field>
        <mat-form-field>
        <input [(ngModel)]="loan.Created" matInput placeholder="Time" value="2019-11-22T00:00:00">
     </mat-form-field>
     <mat-card-actions layout="row" layout-align="end center">
       <button (click)="post()" md-button class="mat-primary">POST</button>
     </mat-card-actions>
     </mat-card-content>
    </mat-card>`
})
export class NewLoanComponent {



    constructor(private webService : WebService) {}
    borrowersList = [];
    lendersList = [];
    selectedBorrower;
    selectedLender;
  
    loan = {
        BorrowerId: "", 
        lenderId: "", 
        LoanBalance: "", 
        Created: ""
    }

    post() {
        console.log(this.loan);
      this.webService.postLoan(this.loan);
      
    }
    async getBorrowersList() {
        var response = await this.webService.getBorrowersList();
        this.borrowersList = response.json();
    }
    async getLendersList() {
        var response = await this.webService.getLendersList();
        this.lendersList = response.json();
    }

    onChange(newValue) {
        console.log(newValue);
        this.selectedBorrower = newValue;
        // ... do other stuff here ...
        this.loan.BorrowerId = newValue;
    }
    onLenderChange(newValue) {
        console.log(newValue);
        this.selectedLender = newValue;
        // ... do other stuff here ...
        this.loan.lenderId = newValue;
    }
}