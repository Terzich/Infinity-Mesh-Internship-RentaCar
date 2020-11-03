import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Car } from './car-model';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { CarVM } from './car-data';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl="https://localhost:44365/api/car/get";

  options=new HttpHeaders().set('content-type', 'application/json')
  .set('Access-Control-Allow-Origin', '*');

  constructor(private http:HttpClient) { }

  
  getCarsFromServer():Observable<Car[]>{

    return this.http.get<Car[]>(this.apiUrl,{'headers':this.options});
    
  }

  getCarById(id:number):Observable<Car>{

    const url=`${this.apiUrl}/${id}`;
    return this.http.get<Car>(url,{'headers':this.options});

  }


}
