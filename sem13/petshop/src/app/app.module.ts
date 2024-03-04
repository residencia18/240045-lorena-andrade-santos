import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatCardModule } from '@angular/material/card';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PrincipalComponent } from './Pages/principal/principal.component';
import { EditarAtendimentoComponent } from './Pages/editar-atendimento/editar-atendimento.component';
import { CriarAtendimentoComponent } from './Pages/criar-atendimento/criar-atendimento.component';
import { MostrarAtendimentosComponent } from './Pages/mostrar-atendimentos/mostrar-atendimentos.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

const routes: Routes = [
  { path: 'principal', component: PrincipalComponent },
  { path: 'adicionarAtendimento', component: CriarAtendimentoComponent },
  { path: 'listarAtendimentos', component: MostrarAtendimentosComponent },
  { path: 'editarAtendimento/:id', component: EditarAtendimentoComponent },
  { path: '', redirectTo: '/principal', pathMatch: 'full' },
];

@NgModule({
  declarations: [
    AppComponent,
    PrincipalComponent,
    EditarAtendimentoComponent,
    CriarAtendimentoComponent,
    MostrarAtendimentosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCardModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
