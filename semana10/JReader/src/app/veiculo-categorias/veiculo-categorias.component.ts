import { Component, OnInit } from '@angular/core';
import { VeiculoService } from '../veiculo.service';

@Component({
  selector: 'app-veiculo-categorias',
  templateUrl: './veiculo-categorias.component.html',
  styleUrl: './veiculo-categorias.component.css'
})
export class VeiculoCategoriasComponent implements OnInit {
  categorias: string[] = [];
  selecionaCategoria: string | null = null;
  veiculos: any[] = [];
  selecionaVeiculo: any | null = null;
  veiculosProriedades: string[] = [];
  selecionadaPropriedade: string | null = null;

  constructor(private veiculoService: VeiculoService) { }

  ngOnInit(): void {
    this.veiculoService.getVeiculos().subscribe(data => {
      this.categorias = Object.keys(data);
    });
  }
  oncategoriaSelecionada(categoria: string): void {
    this.selecionaCategoria = categoria;
    this.veiculoService.getVeiculosPorCategoria(categoria).subscribe(veiculos => {
      this.veiculos = veiculos;
    });
  }
  onVeiculoSelecionado(veiculo: any): void {
    this.selecionaVeiculo = veiculo;
    this.veiculosProriedades = Object.keys(veiculo);
    this.selecionadaPropriedade = null;
  }
  onPropriedadeClicada(propriedade: any){
    this.selecionadaPropriedade = propriedade;
  }
}
