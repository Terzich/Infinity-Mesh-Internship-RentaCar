import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { CarDetailsComponent } from './car-details/car-details.component';
import { NavigationComponent } from './navigation/navigation.component';
import { BannerComponent } from './banner/banner.component';
import { CarListComponent } from './car-list/car-list.component';
import { FooterComponent } from './footer/footer.component';
import { FormsModule } from '@angular/forms';
import { ContactUsComponent } from './contact-us/contact-us.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { CarCatalogueComponent } from './car-catalogue/car-catalogue.component';
import { RentCarComponent } from './rent-car/rent-car.component';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { NewCarComponent } from './new-car/new-car.component';

@NgModule({
  declarations: [
    AppComponent,
    CarDetailsComponent,
    NavigationComponent,
    BannerComponent,
    CarListComponent,
    FooterComponent,
    ContactUsComponent,
    CarCatalogueComponent,    
    RentCarComponent, NewCarComponent, 
    // BookedCarModelComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    BsDatepickerModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
