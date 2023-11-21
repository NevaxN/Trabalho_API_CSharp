import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../models/Usuario';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class UsuariosService {
  apiUrl = 'http://localhost:5000/Diretor';
  constructor(private http: HttpClient) { }
  listar(): Observable<Usuario[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Usuario[]>(url);
  }
  buscar(usuarioId: number): Observable<Usuario>{
    const url = `${this.apiUrl}/buscar/${usuarioId}`;
    return this.http.get<Usuario>(url);
  }
  cadastrar(usuario: Usuario): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Usuario>(url, usuario, httpOptions)
  }
  alterar(usuario: Usuario): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Usuario>(url, usuario, httpOptions);
  }
  excluir(usuarioId: number): Observable<any>{
    const url = `${this.apiUrl}/excluir/${usuarioId}`;
    return this.http.delete<Usuario>(url, httpOptions);
  }
}
