import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Comentario } from '../models/Comentario';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class ComentariosService {
  apiUrl = 'http://localhost:5000/Comentario';
  constructor(private http: HttpClient) { }
  listar(): Observable<Comentario[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Comentario[]>(url);
  }
  buscar(comentarioId: number): Observable<Comentario>{
    const url = `${this.apiUrl}/buscar/${comentarioId}`;
    return this.http.get<Comentario>(url); 
  }
  cadastrar(comentario: Comentario): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Comentario>(url, comentario, httpOptions);
  }
  alterar(comentario: Comentario): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Comentario>(url, comentario, httpOptions);
  }
  excluir(comentarioId: number): Observable<any>{
    const url = `${this.apiUrl}/buscar/${comentarioId}`
    return this.http.delete<number>(url, httpOptions);
  }
}
