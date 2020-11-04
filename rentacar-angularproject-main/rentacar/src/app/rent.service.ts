import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BookedCar } from './booked-car-model';

@Injectable({
  providedIn: 'root'
})
export class RentService {

  apiUrlSave = "https://localhost:44365/api/bookedcar/save";
  apiUrlGet = "https://localhost:44365/api/bookedcar/get";


  options = new HttpHeaders().set('content-type', 'application/json')
    .set('Access-Control-Allow-Origin', '*');


  constructor(private http: HttpClient) { }

  getBookedCars():Observable<BookedCar[]>
  {
    return this.http.get<BookedCar[]>(this.apiUrlGet,{'headers':this.options});
    
  }

  addBookedCar(bookedCar: BookedCar): Observable<number> {

    return this.http.post<number>(this.apiUrlSave, bookedCar, { "headers": this.options });

  }



}


  

  

