import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BookedCar } from './booked-car-model';

@Injectable({
  providedIn: 'root'
})
export class RentService {

  apiUrl = "https://localhost:44365/api/bookedcar/save";

  options = new HttpHeaders().set('content-type', 'application/json')
    .set('Access-Control-Allow-Origin', '*');


  constructor(private http: HttpClient) { }
  addBookedCar(bookedCar: BookedCar): Observable<number> {

    return this.http.post<number>(this.apiUrl, bookedCar, { "headers": this.options });

  }



}


  

  

