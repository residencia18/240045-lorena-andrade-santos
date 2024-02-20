import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-form-usuario',
  templateUrl: './form-usuario.component.html',
  styleUrl: './form-usuario.component.css'
})
export class FormUsuarioComponent  implements OnInit {
  usuarioForm!: FormGroup;
  hide = true;
  profissoes: string[] = ['Engenheiro', 'Médico', 'Advogado', 'Professor', 'Programador', 'Designer', 'Outra'];
  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.usuarioForm = this.formBuilder.group({
      nomeUsuario: ['', [Validators.required, Validators.maxLength(12), this.noSpacesValidator]],
      password: ['', [Validators.required, Validators.minLength(4), this.passwordValidator]],
      email:['', Validators.email],
      nomeCompleto: ['', [Validators.required, this.nomeCompletoValidator]],
      telefone:['',[Validators.required, this.validarTelefone]],
      endereco:['',[Validators.required]],
      dataNascimento:['',[Validators.required, this.validarDataNascimento]],
      genero: ['', [Validators.required]],

    });
  }

  noSpacesValidator(control: AbstractControl) {
    if (control.value && control.value.trim().indexOf(' ') >= 0) {
      return { 'noSpaces': true };
    }
    return null;
  }

  submitForm() {
    if (this.usuarioForm.valid) {
      const userData = this.usuarioForm.value;
      console.log(userData);
    }
  }
  
  passwordValidator(control: AbstractControl) {
    if (control.value && !/(?=.*[A-Z])(?=.*[!@#$%^&*])(?=.{4,})/.test(control.value)) {
      return { 'invalidPassword': true };
    }
    return null;
  }
  nomeCompletoValidator(control: AbstractControl){
    const value = control.value;
    if (value.indexOf(' ') === -1) { // Verifica se há um espaço no valor
      return { 'invalidFullName': true }; // Retorna um erro se não houver espaço
    }
    return null; 
  }
  validarTelefone(control: AbstractControl){
    const telefoneRegex = /^\(\d{2}\) \d{5}-\d{4}$/; // Expressão regular para telefone do Brasil (formato: (99) 99999-9999)
    if (control.value && !telefoneRegex.test(control.value)) {
      return { 'telefoneInvalido': true };
    }
    return null;
  }

  
  validarDataNascimento(control: AbstractControl) {
    const dataNascimento = control.value;
    // Verifica se a data de nascimento é uma data válida
    if (isNaN(Date.parse(dataNascimento))) {
      return { 'dataInvalida': true };
    }

    // Calcula a idade com base na data de nascimento fornecida
    const hoje = new Date();
    const nascimento = new Date(dataNascimento);
    const diff = hoje.getTime() - nascimento.getTime();
    const idade = Math.floor(diff / (1000 * 60 * 60 * 24 * 365.25));

    // Verifica se a idade é menor que 18 anos
    if (idade < 18) {
      return { 'menorDeIdade': true };
    }

    return null;
  }

}
