import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CartService {

    cartItem = [
      {
        id: 1,
        product: {
          id: 10,
          name: 'Product 1',
          price: 100,
          desscription: 'Description of product 1',
        }, 
        quantity: 4,
        userId: 1,
      },
      {
        id: 2,
        product: {
          id: 20,
          name: 'Product 2',
          price: 300,
          desscription: 'Description of product 2',
        }, 
        quantity: 5,
        userId: 1,
      }
    ]

  constructor() { }

  getAll(){
    return this.cartItem;
  }
}
