import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StoreWithItemsDto } from '../models/storeWithItemsDto';
import { ItemDto } from '../models/ItemDto';

@Injectable({
  providedIn: 'root'
})

export class StoreService {

  private baseUrl = 'http://localhost:5000/api/stores'; // URL do servidor C#
  private baseUrlIten = 'http://localhost:5000';

  constructor(private httpClient: HttpClient ) {}

  public getStoreWithItemsFirstLogin(): Observable<StoreWithItemsDto> {
    let mailStore = localStorage.getItem('mailStore');
    console.warn('Email específicado: ' + mailStore)
    if(mailStore){
      let emailSemAspas = mailStore.replace(/"/g, '');
      return this.httpClient.get(`${this.baseUrl}/WithItemsByMail/${emailSemAspas}`);
    }else{
      return this.httpClient.get(`${this.baseUrl}/WithItemsByMail/${mailStore}`);
    }
  }
  public addItemsToStoreById(storeId : number, product:ItemDto ): Observable<any> {
    debugger
    return this.httpClient.post(`${this.baseUrlIten}/${storeId}/product`, product);
  }
  public removeItemById(storeId : number, itemId:number ): Observable<any>  {
    return this.httpClient.delete(`${this.baseUrlIten}/${storeId}/product/${itemId}`);
  }
  public editItemById(storeId : number, itemId:number , item:ItemDto ): void {
    this.httpClient.put(`${this.baseUrlIten}/${storeId}/product/${itemId}`,item);
  }
}
