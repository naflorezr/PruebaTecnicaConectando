import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { checkToken } from '@interceptors/token.interceptor';
import { Categoria } from '@models/categoria.model';

@Injectable({
  providedIn: 'root',
})
export class CategoriaService {
  apiUrl = environment.API_URL;

  constructor(private http: HttpClient) {}

  getCategories() {
    return this.http.get<Categoria[]>(`${this.apiUrl}Categoria/GetCategorias/GetCategory`, {
      context: checkToken(),
    });
  }
}
