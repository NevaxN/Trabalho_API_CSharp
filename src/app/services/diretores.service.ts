import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Diretor } from '../models/Diretor';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class DiretoresService {
  apiUrl = 'http://localhost:5000/Diretor';
  constructor(private http: HttpClient) { }
  listar(): Observable<Diretor[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Diretor[]>(url);
  }
  buscar(diretorId: number): Observable<Diretor>{
    const url = `${this.apiUrl}/buscar/${diretorId}`;
    return this.http.get<Diretor>(url);
  }
  cadastrar(diretor: Diretor): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Diretor>(url, diretor, httpOptions);
  }
  alterar(diretor: Diretor): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Diretor>(url, diretor, httpOptions);
  }
  excluir(diretorId: number): Observable<any>{
    const url = `${this.apiUrl}/excluir/${diretorId}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
