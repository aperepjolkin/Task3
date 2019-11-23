import { Component } from '@angular/core';
import { LoansComponent } from './loans.component';
import { NewLoanComponent } from './new-loan.component';

@Component({
  selector: 'app-root',
  template: '<reports></reports><new-borrower></new-borrower><new-lender></new-lender><new-loan></new-loan><loans></loans>',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'frontend';

}
