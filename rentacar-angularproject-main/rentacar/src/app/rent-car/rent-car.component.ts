import { Component, Input, OnInit, SimpleChanges } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookedCar } from '../booked-car-model';
import { Car } from '../car-model';
import { CarService } from '../car.service';
import { RentService } from '../rent.service';

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
  message:string;

  constructor(private route: ActivatedRoute,private carService : CarService, private rentService : RentService,private router:Router) {
  
   }

  ngOnInit(): void {
    
    this.carService.getCarById(+this.route.snapshot.paramMap.get('id')).subscribe(carFromAPI=> this.Car=carFromAPI);
  }

  calculatePrice():void{
    const diffInMs = Math.abs(this.bsRangeValue[1].valueOf() - this.bsRangeValue[0].valueOf());
   var r= diffInMs / (1000 * 60 * 60 * 24);
    this.totalPrice=this.Car.price*r;
  }
  
  rentCar(){
    let data:BookedCar={
      userID:1,
      carID:this.Car.id,
      from:this.bsRangeValue[0],
      to:this.bsRangeValue[1],
      totalPrice:this.totalPrice,
      rating:5,
      comment:"Savrsen automobil",
      commentCreated:this.bsRangeValue[1]
    };
    this.rentService.addBookedCar(data).subscribe();
    this.message="Uspješno ste rentali vozilo!";
    setTimeout( () => {
     this.router.navigateByUrl("");
    } ,3000);
    
  }
  
}
