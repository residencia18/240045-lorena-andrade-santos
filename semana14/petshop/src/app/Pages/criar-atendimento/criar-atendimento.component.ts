import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BancoService } from '../../banco.service';

@Component({
  selector: 'app-criar-atendimento',
  templateUrl: './criar-atendimento.component.html',
  styleUrl: './criar-atendimento.component.css'
})
export class CriarAtendimentoComponent implements OnInit {
  atendimentoForm!: FormGroup;

  constructor(private formConstrutor: FormBuilder, private servico: BancoService) { }
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
  }

  adicionarAtendimento() {
    if (this.atendimentoForm.valid) {
      console.log(this.atendimentoForm.value);
      this.servico.adicionarAtendimento(this.atendimentoForm.value);
      this.atendimentoForm.reset();
    } else {
      console.log("Formulário inválido. Por favor, preencha todos os campos obrigatórios.");
    }
  }

  onSubmit() {
    console.log(this.atendimentoForm.value);
  }
}
