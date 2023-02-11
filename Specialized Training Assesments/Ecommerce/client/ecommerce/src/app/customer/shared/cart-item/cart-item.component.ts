import { Component, Input } from '@angular/core';
import { faTrash } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-cart-item',
  templateUrl: './cart-item.component.html',
  styleUrls: ['./cart-item.component.css']
})
export class CartItemComponent {
    @Input("item") cartItem: any;
    faTrash = faTrash;

    updateQuantity(e:MouseEvent) {
        let target = e.target as HTMLOptionElement;
        let option = target.getAttribute("data-action");

        if (option === 'sub' && this.cartItem.quantity === 1) {
            return;
        }

        if (option === 'add' && this.cartItem.quantity === 5) {
            return;
        }

        this.cartItem.quantity += option === 'add' ? 1 : -1;

    }
}
