import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StoreFormDto } from '../../cadastro/components/Models/store-form-dto';
import { StoreWithItemsDto } from '../models/storeWithItemsDto';

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
}
