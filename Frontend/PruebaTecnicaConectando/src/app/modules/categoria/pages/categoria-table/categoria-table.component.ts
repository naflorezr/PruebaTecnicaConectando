import { Component, OnInit } from '@angular/core';

import { DataSourceCategoria } from './data-source';
import { CategoriaService } from '@services/categoria.service';
import { AuthService } from '@services/auth.service';
import { Categoria } from '@models/categoria.model';
import { User } from '@models/user.model';

@Component({
  selector: 'app-categoria-table',
  templateUrl: './categoria-table.component.html'
})
export class CategoriaTableComponent implements OnInit {

  dataSource = new DataSourceCategoria();
  columns: string[] = ['id', 'nombre'];
  categoria: Categoria | null = null;

  constructor(
    private categoriaService: CategoriaService,
    private authService: AuthService
  ) {}

  ngOnInit(): void {
    this.getCategory();
    this.authService.categoria$
    .subscribe(categoria => {
      this.categoria= categoria;
    })
  }

  getCategory() {
    this.categoriaService.getCategories()
    .subscribe(category => {
      this.dataSource.init(category);
    })
  }

}
