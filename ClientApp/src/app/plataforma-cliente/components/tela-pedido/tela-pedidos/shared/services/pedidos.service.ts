import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const baseUrl = (url: string) => `api/stores${url}`;
@Injectable({
  providedIn: 'root'
})

export class PedidosService {
  constructor(
    private httpClient: HttpClient
    ){ }

  public ProcurarServicos(){
    
  }
  public ProcurarPedidos(){
    return this.httpClient.get<any>(`http://localhost:4200/api/stores/FullOrders/2`,{});
  }
  public ProcurarProdutos(){}
}
