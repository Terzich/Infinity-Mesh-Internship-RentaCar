import { Component, OnInit } from '@angular/core';
import { Car } from '../car-model';
import { CarService } from '../car.service';

@Component({
  selector: 'app-car-catalogue',
  templateUrl: './car-catalogue.component.html',
  styleUrls: ['./car-catalogue.component.scss']
})
export class 
CarCatalogueComponent implements OnInit {

  cars:Car[];
  selectedcar:string = 'Mercedes Benz C220';
  savedCar:Car;
  constructor(private carService : CarService) { 
  }
  
  ngOnInit(): void {
    this.carService.getCarsFromServer().subscribe(carsFromApi=>
      this.cars=carsFromApi);
      console.log(this.cars);
      
  }
 
  openDetails(car:Car):void{
    this.savedCar = car;
  }

}
