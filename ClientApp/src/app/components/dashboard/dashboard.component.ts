import { StoreService } from './shared/store.service';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Product } from '../../aplication/api/product';
import { ProductService } from '../../aplication/service/product.service';
import { Subscription } from 'rxjs';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { Pedidos } from './models/pedido.model';
import { PedidosService } from './models/pedidos.service';
import { StoreWithItemsDto } from './models/storeWithItemsDto';

@Component({
    templateUrl: './dashboard.component.html',
    styleUrls: ['./dashboard.component.scss']
})

export class DashboardComponent implements OnInit {
    emailLoja?: string;
    products!: Product[];
    pedidos!: Pedidos[];
    chartData: any;

    private _storeWithItems !: StoreWithItemsDto;
    public get storeWithItems() : StoreWithItemsDto {
      return this._storeWithItems;
    }
    public set storeWithItems(v : StoreWithItemsDto) {
      this._storeWithItems = v;
      console.warn(v)
    }



    constructor(private productService: ProductService, public layoutService: LayoutService, public pedidoService: PedidosService, private storeService:StoreService) {
       this.chamarPedidos();
    }

    ngOnInit() {
      this.setarStoreWithItems();
    }

    public chamarPedidos(){
        this.pedidos = this.pedidoService.pedir()
    }

    public setarStoreWithItems(){
      this._storeWithItems;
      this.storeService.getStoreWithItemsFirstLogin().subscribe(data => {
        if(data){
          this._storeWithItems = data;
        }
        console.warn('Informações da com loja com itens :' + data.name)
      });
    }

}
