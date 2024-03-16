import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/enviroment';



@Injectable({
  providedIn: 'root'
})
export class UsuariosService {
myAppUrl:string;
myApiUrl:string;
  constructor(private http:HttpClient) { 
    this.myAppUrl=environment.endpoint;
    this.myApiUrl='/api/Usuario/'
  }
  
  getUsers():Observable<any>{
    return this.http.get(this.myAppUrl+this.myApiUrl);
  }

}
