// angular modules
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

// angular material modules
import { MatSliderModule } from '@angular/material/slider';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from "@angular/material/divider";
import { MatIconModule } from "@angular/material/icon";
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatMenuModule } from "@angular/material/menu";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatFormFieldModule  } from "@angular/material/form-field";
import { MatAutocompleteModule } from "@angular/material/autocomplete";
import { MatInputModule } from "@angular/material/input";
import { MatTableModule } from "@angular/material/table";
import { MatPaginatorModule } from "@angular/material/paginator";
import { MatSortModule } from "@angular/material/sort";

// components
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';

// services
import { HttpErrorHandler } from './services/http-error-handler.service';
import { EmployeeService } from './services/employee.service';
import { RequestCache, RequestCacheWithMap } from './services/request-cache.service';
import { MessageService } from './services/message.service';
import { LoginComponent } from './oauth/login/login.component';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductRowComponent } from './product-list/product-row/product-row.component';
import { ProductImageComponent } from './product-list/product-image/product-image.component';
import { ProductDepartmentComponent } from './product-list/product-department/product-department.component';
import { PriceDisplayComponent } from './product-list/price-display/price-display.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    EmployeeListComponent,
    LoginComponent,
    ProductListComponent,
    ProductRowComponent,
    ProductImageComponent,
    ProductDepartmentComponent,
    PriceDisplayComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatButtonModule,
    MatDividerModule,
    MatIconModule,
    MatSidenavModule,
    MatMenuModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatAutocompleteModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule
  ],
  providers: [
    HttpErrorHandler,
    EmployeeService,
    MessageService,
    { provide: RequestCache, useClass: RequestCacheWithMap },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
