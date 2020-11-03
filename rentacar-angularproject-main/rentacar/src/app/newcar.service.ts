import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from './car-model';


@Injectable({
  providedIn: 'root'
})
export class NewcarService {

  formData : Car={
    id: null,
    carName:null,
    yearOFProduction:0,
    horsePower:0,
    numberOfDoors:0,
    price:0,
    imageURL:null,
    carDetails:null,
    colorId:1
  }

  readonly rootURL = 'https://localhost:44365/api/Car/Save';
  
  constructor(public http:HttpClient) { }
  
  SaveCar(car:Car): Observable<number> {
      debugger;
    const headers = { 'content-type': 'application/json'}  
    return this.http.post<number>(this.rootURL,car);
  }
}
