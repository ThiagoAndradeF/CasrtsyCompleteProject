import { Component } from '@angular/core';
@Component({
  selector: 'app-plataforma-cliente',
  templateUrl: './plataforma-cliente.component.html',
  styleUrls: ['./plataforma-cliente.component.scss']
})
export class PlataformaClienteComponent {
  messageErrorEvolucao:boolean = false;
  public telaPagamentos:boolean = false;
  public telaPedidos:boolean = false;
  public telaCatalogos:boolean = true;
  loadingCatalogo:boolean = false;
  public selecionarPagamentos(){
    this.telaPagamentos = true;
    this.telaPedidos = false
    this.telaCatalogos = false;
  }
  public selecionarCatalogos(){
    this.telaPagamentos = false;
    this.telaPedidos = false
    this.telaCatalogos = true;
  }
  public selecionartelaPedidos(){
    this.telaPagamentos = false;
    this.telaPedidos = true
    this.telaCatalogos = false;
  }

  
}
