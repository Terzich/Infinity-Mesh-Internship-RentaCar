import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarCatalogueComponent } from './car-catalogue/car-catalogue.component';
import { CarListComponent } from './car-list/car-list.component';


const routes:Routes=[
{path: 'carlist',component: CarCatalogueComponent},
{path: '',component: CarListComponent}

] 

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
