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
 
  // onCategoriaSelecionada(event: { categoria: string, veiculos: any[] }) {
  //   this.veiculos = this.dados[event.categoria];
  //   this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
  //   this.propriedades = null;
  // }
  onCategoriaSelecionada(event: { categoria: string, veiculos: any[] }) {
    this.veiculos = this.dados[event.categoria];
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
    this.propriedades = null;
  }
  
  
  onVeiculoSelecionado(veiculo: any) {
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
    this.propriedades = veiculo;
    this.nomes = this.veiculos.map((veiculo: any) => veiculo.Name);
    // this.categoria = veiculo;
  }
  onNomeSelecionado(nome: string) {
    this.propriedades = this.veiculos.find((veiculo: any) => veiculo.Name === nome);
  }
}
