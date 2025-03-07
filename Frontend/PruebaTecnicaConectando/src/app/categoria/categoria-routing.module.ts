import { UsersTableComponent } from './pages/categoria-table/categoria-table.component';

const routes: Routes = [
  {
    path: '',
    component: UsersTableComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriaRoutingModule { }

