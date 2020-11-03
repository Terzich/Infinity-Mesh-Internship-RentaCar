import { Component, OnInit } from '@angular/core';
import { Car } from 'src/app/car-model';
import { CarService } from 'src/app/car.service';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrls: ['./overview.component.scss']
})
export class OverviewComponent implements OnInit {
  cars:Car[];
  constructor(private carService : CarService) { }

  ngOnInit(): void {
    this.carService.getCarsFromServer().subscribe(carsFromApi=>
      this.cars=carsFromApi);
  }

}
