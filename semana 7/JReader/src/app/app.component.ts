// app.component.ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'JReader';
  dados: any;
  file: File | undefined;
  categorias: string[] | undefined;
  veiculos: any[] = [];
  nomes: string[] | undefined;
  propriedades: any;
  valoresSelecionados: any[] = [];
  valorSelecionado: any;


  onFileSelected(event: any) {
    this.file = (event.target as HTMLInputElement)?.files?.[0];
    const reader = new FileReader();
    reader.onload = (e) => {
      this.dados = JSON.parse((e.target as FileReader).result as string);
    };
    if (this.file) {
      reader.readAsText(this.file);
    } else {
      console.error('No file selected');
    }
}

  onLoad() {
    if (this.file) {
      const reader = new FileReader();
      reader.onload = (e) => {
        const text = reader.result?.toString();
        this.dados = JSON.parse(text || ''); 
        this.categorias = Object.keys(this.dados);
      };
      reader.readAsText(this.file);
    }
  }
 
  oncategoriaSelecionada(event: { categoria: string, veiculos: any[] }) {
    this.veiculos = this.dados[event.categoria];
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
    this.propriedades = null;

  }
  
   onVeiculoSelecionado(veiculo: any) {
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
    this.propriedades = veiculo;
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
  }
   onPropriedadeSelecionada(propriedade: any) {
    const valorSelecionado = this.propriedades[propriedade];
    this.valoresSelecionados = Array.isArray(valorSelecionado) ? valorSelecionado : [valorSelecionado];
  }
  

  onValorClicado(valor: any) {
    this.valorSelecionado = valor;
  }
  
}
