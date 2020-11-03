import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ContactModel } from '../app/contact-model';


@Injectable({
  providedIn: 'root'
})
export class ContactService {

  formData : ContactModel={
    Id: null,
    Name:null,
    Email:null,
    Subject:null,
    Message:null
  }

  readonly rootURL = 'https://localhost:44365/api/Contact/Save';
  
  constructor(public http:HttpClient) { }




  saveContact(contact:ContactModel): Observable<number> {
    const headers = { 'content-type': 'application/json'}  
 
    return this.http.post<number>(this.rootURL,contact)
  }
}
