import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CatalogoFilme } from './CatalogoFilme';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class CatalogoFilmesService {
  apiUrl = 'http://localhost:5000/CatalogoFilme';
  constructor(private http: HttpClient) { }
  listar(): Observable<CatalogoFilme[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<CatalogoFilme[]>(url);
  }
}
