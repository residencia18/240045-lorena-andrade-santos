// resultado-pesquisa.component.ts
import { Component, Input } from '@angular/core';

export interface Result { // Adicionando a palavra-chave export
  title: string;
  snippet: string;
  pageid: string;
}
@Component({
  selector: 'app-resultado-pesquisa',
  templateUrl: './resultado-pesquisa.component.html',
  styleUrl: './resultado-pesquisa.component.css'
})
export class ResultadoPesquisaComponent {
  @Input() results: Result[] = [];
  @Input() term: string = '';
}
