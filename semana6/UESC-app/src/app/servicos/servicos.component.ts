// servicos.component.ts

import { Component, OnInit } from '@angular/core';
import { ApiService } from './api.service';

@Component({
  selector: 'app-servicos',
  templateUrl: './servicos.component.html',
  styleUrls: ['./servicos.component.css']
})
export class ServicosComponent implements OnInit {
  weatherData: any; // ou crie uma interface para tipar os dados

  constructor(private apiService: ApiService) {} // Corrigido o nome do serviço

  ngOnInit(): void {
    this.fetchWeatherData();
  }

  fetchWeatherData(): void {
    try {
      const cidade = 'Ilheus';
      this.apiService.getWeatherData(cidade).subscribe(
        (data) => {
          this.weatherData = data;
        },
        (error) => {
          console.error(error);
        }
      );
    } catch (error) {
      console.error(error);
    }
  }
}
