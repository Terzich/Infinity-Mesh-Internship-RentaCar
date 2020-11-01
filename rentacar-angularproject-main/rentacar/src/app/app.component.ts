import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'demo1';

  items:string[]=[];


  addItem(value:string){
    this.items.push(value);
  }
}
