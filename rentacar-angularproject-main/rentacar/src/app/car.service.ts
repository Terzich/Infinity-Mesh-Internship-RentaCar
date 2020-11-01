import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CARS } from './car-data';
import { Car } from './car-model';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl="https://localhost:44365/api/car/get";

  options=new HttpHeaders().set('content-type', 'application/json')
  .set('Access-Control-Allow-Origin', '*');

  constructor(private http:HttpClient) { }

  getCars():Car[]{
    return CARS;
  }
  getCarsFromServer():Observable<Car[]>{

    return this.http.get<Car[]>(this.apiUrl,{'headers':this.options});
    
  }

}
