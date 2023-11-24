import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {


  private baseUrl = 'http://localhost:5000'; // URL do servidor C#

  constructor(private httpClient: HttpClient, private router:Router ) {}

  public requestLogin(email : string, password: string ): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}/login/${email}/${password}`,{});
  }
  public verificarAuth(){
    let rotaDeNavegacao =this.router.url
    if(localStorage.getItem('authToken')==='logado'   ){
      if(rotaDeNavegacao === ('login' || 'cadastro')){
        this.router.navigate(['']);
      }
    }else{
      this.router.navigate(['/login']);
    }
  }

}
