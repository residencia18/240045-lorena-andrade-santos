// veiculos.component.ts
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-veiculos',
  templateUrl: './veiculos.component.html',
  styleUrl: './veiculos.component.css'
})
export class VeiculosComponent  implements OnInit {
  @Input() categoria: any;
  @Input() veiculos: any[] = [];
  @Output() veiculoSelecionado = new EventEmitter<any>();
  dados: any;
  constructor() { }

  ngOnInit(): void {
  }

  // onSelect(veiculo: any) {
  //   this.veiculoSelecionado.emit(veiculo);
  // }
  
  onSelect(veiculo: any) {
    this.veiculoSelecionado.emit(veiculo);
  }
  
}
