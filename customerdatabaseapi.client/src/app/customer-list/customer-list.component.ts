import { Component, OnInit } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { CustomerListService } from '../customer-list.service';
import { Customer } from '../customer';





@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrl: './customer-list.component.css',
  /*imports: [NgFor, NgIf]*/
})
export class CustomerListComponent implements OnInit {

  customers: Customer[] = [];

  constructor(private Customerlistservice: CustomerListService) {}

  ngOnInit(): void {
    this.loadcustomers();

    //this.getAllCustomerlist();
  }

  loadcustomers(): void {

    this.Customerlistservice.getAllCustomerlist()
      .subscribe(customers => this.customers = customers);

  }
  






}
