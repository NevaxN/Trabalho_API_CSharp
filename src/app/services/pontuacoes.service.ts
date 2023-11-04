import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pontuacao } from '../models/Pontuacao';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class PontuacoesService {
  apiUrl = 'http://localhost:5000/Diretor';
  constructor(private http: HttpClient) { }
  listar(): Observable<Pontuacao[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Pontuacao[]>(url);
  }
  buscar(pontuacaoId: number): Observable<Pontuacao>{
    const url = `${this.apiUrl}/buscar/${pontuacaoId}`;
    return this.http.get<Pontuacao>(url);
  }
  cadastrar(pontuacao: Pontuacao): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Pontuacao>(url, pontuacao, httpOptions);
  }
  alterar(pontuacao: Pontuacao): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Pontuacao>(url, pontuacao, httpOptions);
  }
  excluir(pontuacaoId: number): Observable<any>{
    const url = `${this.apiUrl}/excluir/${pontuacaoId}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
