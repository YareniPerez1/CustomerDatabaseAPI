import { Injectable } from '@angular/core';
import { Customerlist } from './customerlist';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerListService {

  constructor(private http: HttpClient) { }

  //create

  createCustomerlist(newCustomerlist: Customerlist): Observable<Customerlist> {
    //create new customer in database

    return this.http.post<Customerlist>("/api/Customers", newCustomerlist);


  }


  //read
  getAllCustomerlist(): Observable<Customerlist[]>{
    //get all customers from api
    return this.http.get<Customerlist[]>("/api/Customers")

  }

  

  getCustomerlistById(id: number) {
    //get a customer by id

  }

  //update
  updateCustomerlist(id: number, newCustomerlist: Customerlist): Observable<Customerlist> {

    return this.http.put<Customerlist>("/api/Customers/" + id, newCustomerlist);

  }

  //delete
  deleteCustomerlist(id: number): Observable<any> {

    return this.http.delete<any>("/api/Customers/" + id);
   // delete a specific customer list


  }

}
