import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CustomerListService } from './customer-list.service';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { Customer } from './customer';
import { NgModule } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';




@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  template: '<app-customer-list></app-customer-list'

})
export class AppComponent{
  

  customer: Customer[] = [];

  
  //all below is needed for CRUD
  constructor(private customerlist: CustomerListService) { }

  ngOnInit() {

    this.getAllCustomerlist();
  }


   getAllCustomerlist () {
    
    this.customerlist.getAllCustomerlist().subscribe(data => {
      this.customer = data;

    })
  }

 

  title = 'customerdatabaseapi.client';
}
