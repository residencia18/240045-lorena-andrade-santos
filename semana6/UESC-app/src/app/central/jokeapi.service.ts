// joke-api.service.ts

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JokeApiService {
  private apiUrl = 'https://v2.jokeapi.dev/joke/Any?lang=pt';

  async getJokes(): Promise<any> {
    const response = await fetch(this.apiUrl);

    if (!response.ok) {
      throw new Error(`Erro ao buscar piadas da API: ${response.statusText}`);
    }

    return response.json();
  }
}
