import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarCatalogueComponent } from './car-catalogue/car-catalogue.component';
import { CarListComponent } from './car-list/car-list.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { OverviewComponent } from './dashboard/overview/overview.component';
import { RentCarComponent } from './rent-car/rent-car.component';


const routes:Routes=[
{path: 'carlist',component: CarCatalogueComponent},
{path: '',component: CarListComponent},
{path: 'dashboard',component: DashboardComponent},
{path: 'rentcar/:id',component: RentCarComponent}



] 

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
