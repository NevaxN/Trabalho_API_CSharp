import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Catalogo } from './Catalogo';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class CatalogosService {
  apiUrl = 'http://localhost:5000/Catalogo';
  constructor(private http: HttpClient) { }
  listar(): Observable<Catalogo[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Catalogo[]>(url);
  }
  buscar(catalogoId: number): Observable<Catalogo>{
    const url = `${this.apiUrl}/buscar/${catalogoId}`;
    return this.http.get<Catalogo>(url);
  }
  cadastrar(catalogo: Catalogo): Observable<any>{
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Catalogo>(url, catalogo, httpOptions);
  }
  alterar(catalogo: Catalogo): Observable<any>{
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Catalogo>(url, catalogo, httpOptions)
  }
  excluir(catalogoId: number): Observable<any>{
    const url = `${this.apiUrl}/buscar/${catalogoId}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
