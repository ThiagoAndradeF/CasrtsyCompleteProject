import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StoreWithItemsDto } from '../models/storeWithItemsDto';
import { ItemDto } from '../models/ItemDto';
import { AdditionalServiceDto } from '../models/AdditionalServiceDto';
import { OrderDto } from '../models/OrderDto';

@Injectable({
  providedIn: 'root'
})

export class StoreService {
  private storeId!:number;
  private baseUrl = 'http://localhost:5000/api/stores';
  private baseUrlIten = 'http://localhost:5000';

  constructor(private httpClient: HttpClient ) {
    if( localStorage.getItem('idLoja')){
      this.getIdLoja();
    }
  }

  public getIdLoja(){
    let idLoja =  localStorage.getItem('idLoja');
    if(idLoja){
      this.storeId = parseFloat(idLoja);
    }
  }


  //GET
  public getStoreWithItemsFirstLogin(): Observable<StoreWithItemsDto> {
    let mailStore = localStorage.getItem('mailStore');
    console.warn('Email específicado: ' + mailStore);

    if(mailStore){
      let emailSemAspas = mailStore.replace(/"/g, '');
      return this.httpClient.get(`${this.baseUrl}/WithItemsByMail/${emailSemAspas}`);
    }else{
      return this.httpClient.get(`${this.baseUrl}/WithItemsByMail/${mailStore}`);
    }
  }
  public compareCredentials(email: string, password: string){
    return this.httpClient.get(`${this.baseUrl}/login/${email}/${password}`);
  }
  public getStoreWithServices(storeId: number = this.storeId) : Observable<any>{
    return this.httpClient.get(`${this.baseUrl}/WithServices/${storeId}`);
  }
  public getAllOrders(storeId: number = this.storeId) : Observable<any>{
    return this.httpClient.get(`${this.baseUrlIten}/api/orders/${storeId}`);
  }


  //POST
  public addItemsToStoreById(storeId : number, product:ItemDto ): Observable<any> {
    return this.httpClient.post(`${this.baseUrlIten}/${storeId}/product`, product);
  }
  public addServicesToStoreById(service:AdditionalServiceDto, storeId : number =this.storeId ): Observable<any> {
    return this.httpClient.post(`${this.baseUrlIten}/${storeId}/service`, service);
  }
  public addOrderToStory(order:OrderDto ): Observable<any> {
    order.storeId = this.storeId ;
    debugger
    return this.httpClient.post(`${this.baseUrlIten}/api/orders`, order);
  }

  //PUT
  public editItemById(storeId : number, itemId:number , item:ItemDto ): Observable<any> {
    return this.httpClient.put(`${this.baseUrlIten}/${storeId}/product/${itemId}`,item);
  }

  //DELETE
  public removeItemById(storeId : number, itemId:number ): Observable<any>  {
    return this.httpClient.delete(`${this.baseUrl}/${storeId}/product/${itemId}`);
  }
  public removeServiceById(serviceId:number ): Observable<any>  {
    return this.httpClient.delete(`${this.baseUrlIten}/service/${serviceId}`);
  }


}
