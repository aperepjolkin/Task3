import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs';

@Injectable()
export class WebService {
    BASE_URL = 'https://localhost:44321/api';

    loans = []
    higestLender = {
        name: "",
        balance: ""
    }
    constructor(private http: Http) {
        this.getLoans();
        this.getHighestLender();
    }

    async getLoans() {
       var response = await this.http.get(this.BASE_URL + '/loans').toPromise();
       this.loans = response.json();
       //return this.http.get('https://api.exchangeratesapi.io/latest').toPromise();
    }
    async postLoan(loan) {
        console.log("Post loan");
        console.log(loan);
        var response = await this.http.post(this.BASE_URL + '/loans', loan).toPromise();
        this.loans.push(response.json());
        await this.getHighestLender();
    }
     async getHighestLender() {
        var response = await this.http.get(this.BASE_URL + '/reports/MostHigherLender').toPromise();
        this.higestLender = response.json();
        //return response.json();
        //console.log(this.higestLender);
        //return this.http.get('https://api.exchangeratesapi.io/latest').toPromise();
     }
    addBorrower(newBorrower) {
        console.log("addBorrower called");
        console.log(newBorrower);
        return  this.http.post(this.BASE_URL + '/borrowers', newBorrower).toPromise();
    }
    addLender(newLender) {
        console.log("addBorrower called");
        console.log(newLender);
        return  this.http.post(this.BASE_URL + '/lenders', newLender).toPromise();
    }
    getBorrowersList() {
        return  this.http.get(this.BASE_URL + '/borrowers').toPromise();
        //return this.http.get('https://api.exchangeratesapi.io/latest').toPromise();
     }
     getLendersList() {
        return  this.http.get(this.BASE_URL + '/lenders').toPromise();
        //return this.http.get('https://api.exchangeratesapi.io/latest').toPromise();
     }
}