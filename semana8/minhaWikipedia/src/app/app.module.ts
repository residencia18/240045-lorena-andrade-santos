import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BoldPipe } from './bold.pipe';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ResultadoPesquisaComponent } from './resultado-pesquisa/resultado-pesquisa.component';
import { FazerAPesquisaComponent } from './fazer-apesquisa/fazer-apesquisa.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HttpClientJsonpModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    ResultadoPesquisaComponent,
    BoldPipe,
    FazerAPesquisaComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    HttpClientJsonpModule, 
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
