import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoansComponent } from './loans.component';
import { BrowserAnimationsModule  } from '@angular/platform-browser/animations';
import { MatButtonModule, MatCardModule, MatInputModule, MatCardActions, MatSelectModule } from '@angular/material';
import { WebService } from './web.service';
import { HttpModule } from '@angular/http';
import { NewLoanComponent } from './new-loan.component';
import { FormsModule } from '@angular/forms';
import { NewBorrowerComponent } from './new-borrower.component';
import { NewLenderComponent } from './new-lender.component';
import { ReportsComponent } from './reports.component';

@NgModule({
  declarations: [
    AppComponent,
    NewLoanComponent,
    LoansComponent,
    NewBorrowerComponent,
    NewLenderComponent,
    ReportsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatCardModule,
    HttpModule,
    MatInputModule,
    FormsModule,
    MatSelectModule
  ],
  providers: [WebService],
  bootstrap: [AppComponent],
})
export class AppModule { }
