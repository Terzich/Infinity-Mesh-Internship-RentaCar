import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarCatalogueComponent } from './car-catalogue/car-catalogue.component';
import { CarListComponent } from './car-list/car-list.component';
import { NewCarComponent } from './new-car/new-car.component';
import { RentCarComponent } from './rent-car/rent-car.component';


const routes:Routes=[
{path: 'carlist',component: CarCatalogueComponent},
{path: '',component: CarListComponent},
{path: 'rentcar/:id',component: RentCarComponent},
{path: 'newcar',component: NewCarComponent},

] 

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
