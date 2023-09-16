import { Component } from '@angular/core';
import { Produto } from './models/item-catalogo.model';
@Component({
  selector: 'app-catalogo',
  templateUrl: './catalogo.component.html',
  styleUrls: ['./catalogo.component.scss']
})
 


export class CatalogoComponent {
  pedidos?: Produto[];

  colunas: any = [
    {
      headerName: 'ID', 
      field: 'id', 
      width: 100 },
    { 
      headerName: 'Nome', 
      field: 'nome', 
      width: 200 },
    {
      headerName: 'Imagem do Pedido',
      field: 'imagemUrl',
      width: 200,
      cellRenderer: this.imagemRenderer,
    },
  ];

  // Função para renderizar a imagem do pedido
  imagemRenderer(params:any) {
    return `<img src="${params.value}" style="width: 100px; height: 100px;" />`;
  }

}

