import { Component, ViewChild,ElementRef,Input } from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'loans',
     template: `<div *ngFor="let loan of webService.loans">
                <mat-card style="margin:8px">
                     <mat-card-title> 
                     borrower {{loan.borrowerId}}
                     lender {{loan.lenderId}}
                     <input type="hidden" id="{{loan.id}}" #loanId value="{{loan.id}}">
                     <input type="hidden" id="{{loan.borrowerId}}" #borrowerId value="{{loan.borrowerId}}">
                     <input type="hidden" #lenderId value="{{loan.lenderId}}">         
                     Lender Name:                
                        {{loan.lenderName}}
                      </mat-card-title>
                    <mat-card-content>
                     Borrower Name:
                     {{loan.borrowerName}}
                     Loan Balance:
                     <input type="text" [ngModel]="loan.loanBalance" (blur)="onBlurMethod($event.target.value)" />
                    </mat-card-content>
                 </mat-card>
                </div>`
})
export class LoansComponent {
   @ViewChild('loanId',{static:false}) loanId:ElementRef;
   @ViewChild('borrowerId',{static:false}) borrowerId:ElementRef;
   @ViewChild('lenderId',{static:false}) lenderId:ElementRef;

   loanChange
    constructor(private webService : WebService) {}

    onBlurMethod(newValue:number) {
      const valueInput = this.loanId.nativeElement.value
      const test = this.lenderId.nativeElement.value
      console.log('lender id '+ test);
      this.loanChange = {
        //LoanId: valueInput,
        LoanBalance:newValue,
        lenderId: this.lenderId.nativeElement.value,
        borrowerId: this.borrowerId.nativeElement.value
      };

      console.log(this.loanChange)
      var response =  this.webService.postLoanChange(this.loanChange);
      this.loanChange = response; 
    }
}