import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BancoService } from '../Services/banco.service';

@Component({
  selector: 'app-form-atendimento',
  templateUrl: './form-atendimento.component.html',
  styleUrl: './form-atendimento.component.css'
})
export class FormAtendimentoComponent  implements OnInit{
  atendimentoForm!: FormGroup;

  constructor(private formConstrutor: FormBuilder, private servico: BancoService) { }
  ngOnInit() {
    this. atendimentoForm = this.formConstrutor.group({
      nomeAnimal: ['', Validators.required],
      dataEntrada: ['', Validators.required],
      horaEntrada: ['', Validators.required],
      horaPrevisaoSaida: ['', Validators.required],
      preco: ['', Validators.required],
      telefoneTutor: ['', Validators.required],
      nomeTutor: ['', Validators.required],
    });
  }
  
  adicionarBilhete() {
    console.log(this.atendimentoForm.value);
    this.servico.adicionarAtendimento(this.atendimentoForm.value);
    this.atendimentoForm.reset();
  }

  onSubmit() {
    console.log(this.atendimentoForm.value);
  }
}
