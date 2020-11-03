import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import "jquery";
import { Car } from '../car-model';
import { CarService } from '../car.service';
import { MessageService } from '../message.service';
declare var $:JQueryStatic;

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.scss']
})
export class CarListComponent implements OnInit {

  @Output() newItemEvent=new EventEmitter<string>();
  cars:Car[];
  selectedcar:string = 'Mercedes Benz C220';
  savedCar:Car;
  constructor(private carService : CarService, public messageService: MessageService) { 
  }
  
  ngOnInit(): void {
    this.carService.getCarsFromServer().subscribe(carsFromApi=>
      this.cars=carsFromApi);
      console.log(this.cars);
      
  }
  addNewItem(value:string)
  {
    this.newItemEvent.emit(value);
  }

  openDetails(car:Car):void{
    this.savedCar = car;
  }

  addMessage(){
    this.messageService.add("from parent");
  }
  clearMessages(){
    this.messageService.clear();
  }
  
  
}
