import { Component, OnInit, Input } from '@angular/core';
import { Car } from '../car-model';
import { MessageService } from '../message.service';
import { RentService } from '../rent.service';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.scss']
})
export class CarDetailsComponent implements OnInit {
  @Input() car:Car;
  constructor(public messageService: MessageService, public rentService: RentService) { }
 

  ngOnInit(): void {
  }

  

  addMessage(){
    this.messageService.add("from child");
  }
  clearMessages(){
    this.messageService.clear();
  }


}
