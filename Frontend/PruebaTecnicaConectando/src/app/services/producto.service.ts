import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '@environments/environment';
import { checkToken } from '@interceptors/token.interceptor';
import { Producto } from '@models/producto.model';

@Injectable({
  providedIn: 'root',
})
export class ProductoService {
  apiUrl = environment.API_URL;

  constructor(private http: HttpClient) {}

  getProducts() {
    return this.http.get<Producto[]>(`${this.apiUrl}Producto/GetProductos/GetProduct`, {
      context: checkToken(),
    });
  }
}
