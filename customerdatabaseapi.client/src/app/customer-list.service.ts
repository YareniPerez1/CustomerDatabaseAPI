import { Injectable } from '@angular/core';
import { Customer } from './customer';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerListService {

  constructor(private http: HttpClient) { }

  //create

  createCustomerlist(newCustomerlist: Customer): Observable<Customer> {
    //create new customer in database

    return this.http.post<Customer>("/api/Customers", newCustomerlist);


  }


  //read
  getAllCustomerlist(): Observable<Customer[]>{
    //get all customers from api
    return this.http.get<Customer[]>("/api/Customers")

  }

  

  getCustomerlistById(id: number) : Observable<Customer>{
    //get a customer by id

    return this.http.get<Customer>("/api/Customers/" + id)

  }

  //update
  updateCustomerlist(id: number, newCustomerlist: Customer): Observable<Customer> {

    return this.http.put<Customer>("/api/Customers/" + id, newCustomerlist);

  }

  //delete
  deleteCustomerlist(id: number): Observable<any> {

    return this.http.delete<any>("/api/Customers/" + id);
   // delete a specific customer list


  }

}
