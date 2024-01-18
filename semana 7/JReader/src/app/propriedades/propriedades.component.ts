// propriedades.component.ts
import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-propriedades',
  templateUrl: 'propriedades.component.html',
  styleUrls: ['propriedades.component.css']
})
export class PropriedadesComponent {
  @Input() propriedades: any;
  @Output() valorClicado = new EventEmitter<any>();
  valorSelecionado: any;

  onSelect(valor: any) {
    this.valorSelecionado = valor;
  }
  // propriedades.component.ts
onPropriedadeClicada(valor: any) {
  console.log('Valor clicado:', valor);
  this.valorClicado.emit(valor);
}

}
