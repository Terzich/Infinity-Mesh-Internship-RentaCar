import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from '../car-model';
import { CarService } from '../car.service';

@Component({
  selector: 'app-rent-car',
  templateUrl: './rent-car.component.html',
  styleUrls: ['./rent-car.component.scss']
})
export class RentCarComponent implements OnInit {

  @Input() Car:Car;


  constructor(private route: ActivatedRoute,private carService : CarService) { }

  ngOnInit(): void {
    
    this.carService.getCarById(+this.route.snapshot.paramMap.get('id')).subscribe(carFromAPI=> this.Car=carFromAPI);
  }

}
