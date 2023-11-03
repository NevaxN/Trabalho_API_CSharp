import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GeneroUsuario } from './GeneroUsuario';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class GeneroUsuariosService {
  apiUrl = 'http://localhost:5000/GeneroUsuario';
  constructor(private http: HttpClient) { }
  listar(): Observable<GeneroUsuario[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<GeneroUsuario[]>(url);
  }
}
