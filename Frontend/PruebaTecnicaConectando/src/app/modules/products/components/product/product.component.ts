import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-product',
  standalone: false,
  templateUrl: './product.component.html'
})
export class ProductComponent {
  @Input() id:number = 0;
  @Input() nombre: string = '';
  @Input() cantidad:number = 0;
  @Input() precio:number = 0;
  @Input() imagen: string = '';
}
