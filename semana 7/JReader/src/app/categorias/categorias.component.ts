// categorias.component.ts
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-categorias',
  templateUrl: './categorias.component.html',
  styleUrl: './categorias.component.css'
})
export class CategoriasComponent implements OnInit {
  @Input() categorias: any;
  @Input() veiculos: any[] = [];
  @Output() categoriaSelecionada = new EventEmitter<{ categoria: string, veiculos: any[] }>();

  ngOnInit(): void {}

  onSelect(categoria: any) {
    const veiculosDacategoria = this.categorias[categoria];
    this.categoriaSelecionada.emit({ categoria: categoria, veiculos: veiculosDacategoria });
  }
}
