import { Component, OnInit } from '@angular/core';
import { Car } from '../car-model';
import { CarService } from '../car.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  cars:Car[];
  constructor(private carService : CarService) { }

  ngOnInit(): void {
    this.carService.getCarsFromServer().subscribe(carsFromApi=>
      this.cars=carsFromApi);
  }

}
