import { Component, OnInit } from '@angular/core'
import { WebService} from './web.service'

@Component({
     selector:'reports',
     template: `<mat-card style="margin:8px">
                     <mat-card-title> 
                      Reports
                      </mat-card-title>
                    <mat-card-content>
                    Biggest
                    Lender Name                  
                    <h1>{{webService.higestLender.name}}</h1>
                    Balance                 
                    <h1>{{webService.higestLender.balance}}</h1>
                    </mat-card-content>
                 </mat-card>
                `
})
export class ReportsComponent {
    higestLender = {
        name: "",
        balance: ""
    }
    constructor(private webService : WebService) {}

     async ngOnInit() {
     
      }
            
   
}