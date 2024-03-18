// PetShop/src/app/banco.service.ts
import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Atendimento } from './atendimento.model';
import { exhaustMap, map, take } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class BancoService {

  apiURL = 'https://petshop-b2745-default-rtdb.firebaseio.com/atendimento.json';

  constructor(private http: HttpClient) { }

  adicionarAtendimento(atendimento: {
    nomeAnimal: string,
    dataEntrada: string,
    horaEntrada: string,
    horaPrevisaoSaida: string,
    preco: number,
    telefoneTutor: string,
    nomeTutor: string
  }
  ) {
    return this.http.post(this.apiURL, atendimento).subscribe(
      (response: any) => {
        console.log(response);
      }
    );
  }

  getAtendimentos() {
    //generics da interface Ticket
    //vem do firebase nesse formato
    //ahsduiashuhui:Object
    //dasdasdasdasd:Object

    return this.http.get<{ [key: string]: Atendimento }>('https://petshop-b2745-default-rtdb.firebaseio.com/atendimento.json').pipe(
      map((responseData) => {
        const listaArray: Atendimento[] = [];
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


  apagarTodosAtendimentos() {
    return this.http.delete('https://petshop-b2745-default-rtdb.firebaseio.com/atendimento.json');
  }

  getAtendimento(id: string) {
    return this.http.get<Atendimento>(
      `https://petshop-b2745-default-rtdb.firebaseio.com/atendimento/${id}.json`
    );
  }

  editarAtendimento(
    id: string,
    atendimentoData: {
      nomeAnimal: string;
      dataEntrada: string;
      horaEntrada: string;
      horaPrevisaoSaida: string;
      preco: number;
      telefoneTutor: string;
      nomeTutor: string;
    }) {
    return this.http.put(
      `https://petshop-b2745-default-rtdb.firebaseio.com/atendimento/${id}.json`,
      atendimentoData,
      { observe: 'response' }
    );
  }
}
