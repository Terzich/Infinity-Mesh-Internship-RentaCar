import { Component, Input, OnInit, SimpleChanges } from '@angular/core';
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

  
  bsValue = new Date();
  bsRangeValue: Date[];
  maxDate = new Date();
  totalPrice:number;

  constructor(private route: ActivatedRoute,private carService : CarService) {
  
   }

  ngOnInit(): void {
    
    this.carService.getCarById(+this.route.snapshot.paramMap.get('id')).subscribe(carFromAPI=> this.Car=carFromAPI);
  }

  calculatePrice():void{
    var days=this.bsRangeValue[0].valueOf()-this.bsRangeValue[1].valueOf();
    this.totalPrice=days*this.Car.price;
    console.log(this.totalPrice);
  }
  ngOnChanges(){
    var days=this.bsRangeValue[0].valueOf()-this.bsRangeValue[1].valueOf();
    this.totalPrice=days*this.Car.price;
    console.log(this.totalPrice);
  }

}
