import { Component } from '@angular/core';
import { AutenticaService } from '../../autentica.service';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  
  hide = true;

  formLogin!: FormGroup;

  constructor(private readonly formBuilder: FormBuilder,
    private authService: AutenticaService,
    private route: Router){}

  ngOnInit(): void {
    this.criarFormulario();
  }

  criarFormulario(): void{
    this.formLogin = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email ]],
      senha: ['', [Validators.required, Validators.minLength(6)]]
    })
  }
  login(){
    if(!this.formLogin.valid){
      return;
    }
    this.authService.login(this.formLogin.getRawValue()).then(resposta => {
      this.route.navigate(['principal'])
    },(error) => {
      alert('erro ao tentar fazer o login')
    })
  }
}
