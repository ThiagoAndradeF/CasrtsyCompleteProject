import { Injectable } from '@angular/core';
// import { HttpClient, HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class PedidosService {
  constructor(
    // private httpClient: HttpClient
    ) { }

  public ProcurarServicos(){
    
  }
  public ProcurarPedidos(){
    // return this.httpClient.get<any>(`http://localhost:5000/api/stores/FullOrders/2`);
  }
  public ProcurarProdutos(){}
}
