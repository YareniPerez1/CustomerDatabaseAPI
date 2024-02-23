import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CustomerListService } from './customer-list.service';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { Customerlist } from './customerlist';

//interface WeatherForecast {
//  date: string;
//  temperatureC: number;
//  temperatureF: number;
//  summary: string;
//}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  

  customerlistList: Customerlist[] = [];

  //don't have a customerlist.ts //made one.
  //all below is needed for CRUD
  constructor(private customerlist: CustomerListService) { }

  

  ngOnInit() {
    /* this.getAllCustomerlist();*/
    this.customerlist.getAllCustomerlist().subscribe(data => {
      this.customerlistList = data;

    })
  }

  //getForecasts() {
  //  this.http.get<WeatherForecast[]>('/weatherforecast').subscribe(
  //    (result) => {
  //      this.forecasts = result;
  //    },
  //    (error) => {
  //      console.error(error);
  //    }
  //  );
  //}

  title = 'customerdatabaseapi.client';
}
