import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoriasComponent } from './categorias/categorias.component';
import { VeiculosComponent } from './veiculos/veiculos.component';
import { PropriedadesComponent } from './propriedades/propriedades.component';
import { ValorComponent } from './valor/valor.component';
import { NomesComponent } from './nomes/nomes.component';

@NgModule({
  declarations: [
    AppComponent,
    CategoriasComponent,
    VeiculosComponent,
    PropriedadesComponent,
    ValorComponent,
    NomesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
