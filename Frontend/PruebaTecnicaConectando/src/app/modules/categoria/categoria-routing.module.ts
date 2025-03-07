import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CategoriaTableComponent } from './pages/categoria-table/categoria-table.component';

const routes: Routes = [
  {
    path: '',
    component: CategoriaTableComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriaRoutingModule { }
