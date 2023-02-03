import { Component } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  product:any[] = [];
  constructor(private productService: ProductsService) {
    
  }

  ngOnInit() {
    this.product = this.productService.getAll();
  }

}
