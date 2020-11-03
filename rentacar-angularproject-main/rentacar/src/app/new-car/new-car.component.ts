import { Component, OnInit } from '@angular/core';
import { NewcarService } from '../newcar.service';
import { NgForm } from "@angular/forms";


@Component({
  selector: 'app-new-car',
  templateUrl: './new-car.component.html',
  styleUrls: ['./new-car.component.scss']
})
export class NewCarComponent implements OnInit {
    message: string = null;
  constructor(public service: NewcarService) { }


  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    this.service.SaveCar(form.value).subscribe(data => {
     console.log(data)}

     );
     this.message ="Successfully added new car!";
   
   
   }
   
}
