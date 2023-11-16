import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { StoreFormDto } from './components/Models/store-form-dto';

@Injectable({
  providedIn: 'root'
})
export class CadastroService {
  private baseUrl = 'http://localhost:5000'; // URL do servidor C#

  constructor(private httpClient: HttpClient ) {}

  public getSomeData(store : StoreFormDto): Observable<any> {
    console.log(JSON.stringify(store));
    localStorage.setItem('mailStore', JSON.stringify(store.Email));
    console.warn(localStorage.getItem('mailStore'));
    return this.httpClient.post(`${this.baseUrl}/complete`, store);
  }
}
