// PetShop/src/app/banco.service.ts
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { exhaustMap, map, take } from 'rxjs';
import { Suino } from './Models/suino';
import { PesoSuino } from './Models/pesoSuino';

@Injectable({
  providedIn: 'root'
})

export class BancoService {

  apiURL = 'https://techpig-3d8dc-default-rtdb.firebaseio.com/suinos.json';

  constructor(private http: HttpClient) { }

  adicionarSuino(suino: Suino) {
    return this.http.post(this.apiURL, suino).subscribe(
      (response) => {
        console.log(response);
      }
    );
  }

  getSuinos() {
    return this.http.get<{ [key: string]: Suino }>('https://techpig-3d8dc-default-rtdb.firebaseio.com/suinos.json').pipe(
      map((responseData) => {
        const listaArray: Suino[] = [];
        for (const key in responseData) {
          if ((responseData).hasOwnProperty(key)) {
            listaArray.push({ ...(responseData as any)[key], id: key });
          }
        }
        return listaArray;
      }
      ),
    );
  }


  apagarTodosSuinos() {
    return this.http.delete('https://techpig-3d8dc-default-rtdb.firebaseio.com/suinos.json');
  }

  getSuino(id: string) {
    return this.http.get<Suino>(
      `https://techpig-3d8dc-default-rtdb.firebaseio.com/suinos/${id}.json`
    );
  }

  editarSuino(id: string, suino: Suino) {
    return this.http.put(
      `https://techpig-3d8dc-default-rtdb.firebaseio.com/suinos/${id}.json`,
      suino,
      { observe: 'response' }
    );
  }
  adicionarPesoSuino(idSuino: string, pesoSuino: PesoSuino) {
    return this.http.post(`${this.apiURL}/pesos/${idSuino}.json`, pesoSuino);
  }

  getPesosSuino(idSuino: string) {
    return this.http.get<{ [key: string]: PesoSuino }>(`${this.apiURL}/pesos/${idSuino}.json`);
  }

  apagarTodosPesosSuino(idSuino: string) {
    return this.http.delete(`${this.apiURL}/pesos/${idSuino}.json`);
  }

  getPesoSuino(idSuino: string, idPeso: string) {
    return this.http.get<PesoSuino>(`${this.apiURL}/pesos/${idSuino}/${idPeso}.json`);
  }

  editarPesoSuino(idSuino: string, idPeso: string, pesoSuino: PesoSuino) {
    return this.http.put(`${this.apiURL}/pesos/${idSuino}/${idPeso}.json`, pesoSuino);
  }

  apagarPesoSuino(idSuino: string, idPeso: string) {
    return this.http.delete(`${this.apiURL}/pesos/${idSuino}/${idPeso}.json`);
  }
}
