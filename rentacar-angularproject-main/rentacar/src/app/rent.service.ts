import { Injectable } from '@angular/core';
import { Car } from './car-model';

@Injectable({
  providedIn: 'root'
})
export class RentService {
    rentedCars:Car[]=[];
    numberOfRentedCars:number= 0;
  constructor() { }

  
}
