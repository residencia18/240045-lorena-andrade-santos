import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PrincipalComponent } from './Pages/principal/principal.component';
import { LoginComponent } from './Pages/login/login.component';
import { CadastrarComponent } from './Pages/cadastrar/cadastrar.component';
import { ListarComponent } from './Pages/listar/listar.component';
import { EditarComponent } from './Pages/editar/editar.component';
import { CadastroPesoComponent } from './Pages/cadastro-peso/cadastro-peso.component';
import { EditarPesoComponent } from './Pages/editar-peso/editar-peso.component';
import { ControlePesoComponent } from './Pages/controle-peso/controle-peso.component';

@NgModule({
  declarations: [
    AppComponent,
    PrincipalComponent,
    LoginComponent,
    CadastrarComponent,
    ListarComponent,
    EditarComponent,
    CadastroPesoComponent,
    EditarPesoComponent,
    ControlePesoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
