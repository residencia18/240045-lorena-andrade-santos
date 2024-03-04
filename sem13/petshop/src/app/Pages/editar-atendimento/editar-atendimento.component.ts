import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BancoService } from '../../banco.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-editar-atendimento',
  templateUrl: './editar-atendimento.component.html',
  styleUrl: './editar-atendimento.component.css'
})
export class EditarAtendimentoComponent  {

  atendimentoForm!: FormGroup;
  id:string = '';
  editadoSucesso:boolean = false;

  constructor(private formConstrutor: FormBuilder,
    private servico: BancoService, 
    private rotas:Router, 
    private route: ActivatedRoute) { }

    ngOnInit() {
      this.atendimentoForm = this.formConstrutor.group({
        nomeAnimal: ['', Validators.required],
        dataEntrada: ['', Validators.required],
        horaEntrada: ['', Validators.required],
        horaPrevisaoSaida: ['', Validators.required],
        preco: ['', Validators.required],
        telefoneTutor: ['', Validators.required],
        nomeTutor: ['', Validators.required],
      });
      this.id = this.route.snapshot.paramMap.get('id')!;
      this.getAtendimento(this.id);
    }
  
    // getAtendimento(id: any) {
    //   console.log("id-->"    + id);
    //   this.servico.getAtendimento(id).subscribe(responseData => {
    //     console.log(responseData);
    //     this.atendimentoForm.setValue(responseData);
    //   });
    // }
    getAtendimento(id: any) {
      console.log("id-->" + id);
      this.servico.getAtendimento(id).subscribe(responseData => {
        console.log(responseData);
        if (responseData) { // Verifica se responseData não é null
          this.atendimentoForm.patchValue(responseData);
        } else {
          console.error('Dados do atendimento não encontrados!');
          // Tratar o caso de não encontrar os dados adequadamente
        }
      }, error => {
        console.error('Erro ao buscar atendimento:', error);
        // Tratar o erro adequadamente
      });
    }
    
    salvarAtendimento() {
      console.log("salvar atendimento: " + this.atendimentoForm.value);
      this.servico.editarAtendimento(this.id, this.atendimentoForm.value).subscribe(responseData => {
        if(responseData.status == 200){
          this.editadoSucesso = true;
          this.rediracionaPrincipal();
        }
      });
    }
  
    rediracionaPrincipal(){
      setTimeout(() => {
       this.rotas.navigate(['listarAtendimentos']);
      }, 2000);
      
    }
}
