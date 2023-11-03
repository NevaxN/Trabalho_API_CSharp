import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Watchlist } from './Watchlist';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class WatchlistsService {
  apiUrl = 'http://localhost:5000/Diretor';
  constructor(private http: HttpClient) { }
  listar(): Observable<Watchlist[]>{
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Watchlist[]>(url);
  }
  buscar(watchlistId: number): Observable<Watchlist>{
    const url = `${this.apiUrl}/buscar/${watchlistId}`;
    return this.http.get<Watchlist>(url);
  }
}
