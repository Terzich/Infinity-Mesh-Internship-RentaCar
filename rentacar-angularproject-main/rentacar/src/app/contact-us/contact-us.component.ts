import { Component, OnInit } from '@angular/core';
import { ContactService } from '../contact.service';
import { NgForm } from "@angular/forms";
import { ContactModel } from '../contact-model';


@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.scss']
})
export class ContactUsComponent implements OnInit {
  

  message:string;


  constructor(public service: ContactService) { }

  ngOnInit() {

  }



  
  onSubmit(form: NgForm) {
 this.service.saveContact(form.value).subscribe(data => {
  console.log(data)}


  
  );
  this.message ="Successful";


}






}
