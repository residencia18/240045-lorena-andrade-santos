import { Component, OnInit } from '@angular/core';
import { BancoService } from '../../banco.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrl: './listar.component.css'
})
export class ListarComponent  implements OnInit {
  listaSuinos: any[] = []; 

  constructor(private bancoService: BancoService) { }
  displayedColumns: string[] = ['brinco', 'brincoPai', 'brincoMae', 'dataNascimento', 'dataSaida', 'status', 'sexo', 'editar'];

  ngOnInit(): void {
    this.getSuinos();
  }


  
  getSuinos() {
    this.bancoService.getSuinos().subscribe((suinos) => {
      this.listaSuinos = suinos;
    })
  }

  editarAtendimento(id:any){
    console.log(id);

  }

}
