import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genero } from '../models/Genero';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class GenerosService {
  apiUrl = 'http://localhost:5000/Genero';
  constructor(private http: HttpClient) { }
  listar(): Observable<Genero[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Genero[]>(url);
  }
  buscar(generoId: number): Observable<Genero>{
    const url = `${this.apiUrl}/buscar/${generoId}`;
    return this.http.get<Genero>(url);
  }
  cadastrar(genero: Genero): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Genero>(url, genero, httpOptions);
  }
  alterar(genero: Genero): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Genero>(url, genero, httpOptions);
  }
  excluir(generoId: number): Observable<any>{
    const url = `${this.apiUrl}/excluir/${generoId}`;
    return this.http.delete<Genero>(url, httpOptions);
  }
}
