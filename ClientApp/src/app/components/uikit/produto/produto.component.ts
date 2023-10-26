import { Component } from '@angular/core';
import { Product } from 'src/app/aplication/api/product';
import { ProductService } from 'src/app/aplication/service/product.service';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html',
  styleUrls: ['./produto.component.scss']
})
export class ProdutoComponent {
  produtos!: Product[];

  constructor(private productService: ProductService) {
     this.listarProdutos();
  }

  ngOnInit() {

  }

  listarProdutos(){
      // this.pedidos = this.pedidoService.pedir()
  }
}
