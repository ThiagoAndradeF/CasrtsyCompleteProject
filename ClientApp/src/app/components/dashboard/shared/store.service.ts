import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StoreFormDto } from '../../cadastro/components/Models/store-form-dto';
import { StoreWithItemsDto } from '../models/storeWithItemsDto';
import { ItemDto } from '../models/ItemDto';

@Injectable({
  providedIn: 'root'
})

export class StoreService {

  private baseUrl = 'http://localhost:5000/api/stores'; // URL do servidor C#

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
  public addItemsToStoreById(storeId : number, item:ItemDto ): void {
    this.httpClient.post(`${this.baseUrl}/${storeId}/product`, item);
  }
  public removeItemById(storeId : number, itemId:number ): void {
    this.httpClient.delete(`${this.baseUrl}/${storeId}/product/${itemId}`);
  }
  public editItemById(storeId : number, itemId:number , item:ItemDto ): void {
    this.httpClient.put(`${this.baseUrl}/${storeId}/product/${itemId}`,item);
  }




}
