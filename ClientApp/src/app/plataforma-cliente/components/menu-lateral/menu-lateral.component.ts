import { Component } from '@angular/core';
import { PedidosService } from '../tela-pedido/tela-pedidos/shared/services/pedidos.service'
import { Router } from '@angular/router';
@Component({
  selector: 'app-menu-lateral',
  templateUrl: './menu-lateral.component.html',
  styleUrls: ['./menu-lateral.component.scss']
})
export class MenuLateralComponent {

  constructor(
    private pedidosService: PedidosService,
    private router: Router
    ){
      
    }

  retornaPedidos(){
    this.pedidosService.ProcurarPedidos();
    this.router.navigate(['/pedidos']);
    
  }
  
}
