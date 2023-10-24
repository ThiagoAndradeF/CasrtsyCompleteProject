import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CadastroService {
  private baseUrl = 'http://localhost:5000'; // URL do servidor C#

  constructor(private httpClient: HttpClient) {}

  getSomeData(): Observable<any> {
    return this.httpClient.get(`${this.baseUrl}/api/endpoint`);
  }

}
