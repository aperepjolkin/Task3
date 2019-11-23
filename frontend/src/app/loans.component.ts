import { Component } from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'loans',
     template: `<div *ngFor="let loan of webService.loans">
                <mat-card style="margin:8px">
                     <mat-card-title> 
                     Lender Name                  
                        {{loan.lenderName}}
                      </mat-card-title>
                    <mat-card-content>
                     Borrowers
                     {{loan.borrowerName}}
                     Loan Balance
                     {{loan.loanBalance}}
                    </mat-card-content>
                 </mat-card>
                </div>`
})
export class LoansComponent {

    constructor(private webService : WebService) {}
}