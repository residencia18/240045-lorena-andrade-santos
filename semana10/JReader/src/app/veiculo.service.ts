import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class VeiculoService {

  constructor(private http: HttpClient) { }

  getVeiculos(): Observable<any> {
    return this.http.get<any>('assets/veiculos.json');
  }
  getVeiculosPorCategoria(category: string): Observable<any[]> {
    return this.getVeiculos().pipe(
      map(data => data[category])
    );
  }
}
