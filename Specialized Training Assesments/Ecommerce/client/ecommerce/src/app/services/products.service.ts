import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {
  products = [
    { id: 1, name: 'Product', description: 'product', category: 'General', price: 100},
    { id: 2, name: 'Product', description: 'product', category: 'General', price: 100},
    { id: 3, name: 'Product', description: 'product', category: 'General', price: 100},
    { id: 4, name: 'Product', description: 'product', category: 'General', price: 100},
    { id: 5, name: 'Product', description: 'product', category: 'General', price: 100}
  ]

  constructor() { }
  getAll(){
    return this.products;
  }
}
