// nomes.component.ts
import { Component, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-nomes',
  templateUrl: './nomes.component.html',
  styleUrls: ['./nomes.component.css']
})
export class NomesComponent {
  @Input() nomes: string[] | undefined;
  @Output() nomeSelecionado = new EventEmitter<string>();

  onSelect(nome: string) {
    this.nomeSelecionado.emit(nome);
  }
}
