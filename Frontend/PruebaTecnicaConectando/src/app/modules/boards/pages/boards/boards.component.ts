import { Component, NgModule } from '@angular/core';
import { faBox, faWaveSquare, faClock, faAngleUp, faAngleDown, faHeart, faBorderAll, faUsers, faGear } from '@fortawesome/free-solid-svg-icons';
import { faTrello } from '@fortawesome/free-brands-svg-icons';
import { CategoriaService } from '@services/categoria.service';
import { Categoria } from '@models/categoria.model';
import { ProductComponent } from '@modules/products/components/product/product.component';
import { ProductoService } from '@services/producto.service';
import { Producto } from '@models/producto.model';

@Component({
  selector: 'app-boards',
  standalone: false,
  templateUrl: './boards.component.html'
})

export class BoardsComponent {

  faTrello = faTrello;
  faBox = faBox;
  faWaveSquare = faWaveSquare;
  faClock = faClock;
  faAngleUp = faAngleUp;
  faAngleDown = faAngleDown;
  faHeart = faHeart;
  faBorderAll = faBorderAll;
  faUsers = faUsers;
  faGear = faGear;
  
  columns : Producto[] = [];

  constructor(private categoriaService: CategoriaService, private productoService: ProductoService) { }

  ngOnInit() {
    this.productoService.getProducts().subscribe(data => this.columns = data);
  }
  

}
