import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { VeiculosComponent } from './veiculos/veiculos.component';
import { PropriedadesComponent } from './propriedades/propriedades.component';
import { CategoriasComponent } from './categorias/categorias.component';
import { ValorComponent } from './valor/valor.component';

@NgModule({
  declarations: [
    AppComponent,
    CategoriasComponent,
    VeiculosComponent,
    PropriedadesComponent,
    ValorComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
