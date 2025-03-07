import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CdkTableModule } from '@angular/cdk/table';

import { CategoriaRoutingModule } from './categoria-routing.module';
import { CategoriaTableComponent } from './pages/categoria-table/categoria-table.component';


@NgModule({
  declarations: [
    CategoriaTableComponent,
  ],
  imports: [
    CommonModule,
    CategoriaRoutingModule,
    CdkTableModule
  ]
})
export class CategoriaModule { }
