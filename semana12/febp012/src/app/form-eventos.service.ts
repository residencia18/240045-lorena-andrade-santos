import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class FormEventosService {
  formState: any = {}; // Armazena o estado do formulário e eventos de interação

  constructor() { }

  // Método para registrar evento de interação do usuário
  registrarEvento(evento: string) {
    // Registre o evento de interação como necessário
    console.log('Evento registrado:', evento);
  }

  // Método para armazenar o estado do formulário
  salvarEstadoFormulario(formulario: FormGroup) {
    this.formState = {
      valores: formulario.value,
      status: formulario.status
    };
  }

  // Método para limpar o estado do formulário
  limparEstadoFormulario() {
    this.formState = {};
  }
}
