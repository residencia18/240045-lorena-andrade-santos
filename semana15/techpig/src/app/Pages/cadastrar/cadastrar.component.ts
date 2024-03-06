import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BancoService } from '../../banco.service';

@Component({
  selector: 'app-cadastrar',
  templateUrl: './cadastrar.component.html',
  styleUrl: './cadastrar.component.css'
})
export class CadastrarComponent implements OnInit {
  suinoForm!: FormGroup;
  constructor(private fb: FormBuilder, private servico: BancoService) { }

  ngOnInit() {
    this.suinoForm = this.fb.group({
      brinco: ['', [Validators.required, Validators.pattern('^[0-9]*$')]],
      brincoPai: ['', [Validators.required, Validators.pattern('^[0-9]*$')]],
      brincoMae: ['', [Validators.required, Validators.pattern('^[0-9]*$')]],
      dataNascimento: ['', Validators.required],
      dataSaida: ['', Validators.required],
      status: ['', Validators.required],
      sexo: ['', Validators.required],
    });
  }

  adicionarSuino() {
    if (this.suinoForm.valid) {
      console.log(this.suinoForm.value);
      this.servico.adicionarSuino(this.suinoForm.value);
      this.suinoForm.reset();
    } else {
      console.log("Formulário inválido. Por favor, preencha todos os campos obrigatórios.");
    }
  }
}
