import { Component, OnInit } from '@angular/core';
import { BancoService } from '../../banco.service';
import { Atendimento } from '../../atendimento.model';

@Component({
  selector: 'app-mostrar-atendimentos',
  templateUrl: './mostrar-atendimentos.component.html',
  styleUrl: './mostrar-atendimentos.component.css'
})
export class MostrarAtendimentosComponent implements OnInit{
  loadedAtendimentos: Atendimento[] = [];
  constructor(private bancoService: BancoService) { }

  ngOnInit() {
    this.getAtendimentos();
  }
  
  getAtendimentos() {
    this.bancoService.getAtendimentos().subscribe(responseData => {
      console.log(responseData);
      this.loadedAtendimentos = responseData;
      console.log(this.loadedAtendimentos);
    });
  }

  editarAtendimento(id:any){
    console.log(id);

  }

  apagarTudo(){
    this.bancoService.apagarTodosAtendimentos().subscribe( () => {
      console.log('Apagou tudo');
      this.loadedAtendimentos = [];
    });
  }
  

}
