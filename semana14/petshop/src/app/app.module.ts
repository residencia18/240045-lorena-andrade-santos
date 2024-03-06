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
import { EditarAtendimentoComponent } from './Pages/editar-atendimento/editar-atendimento.component';
import { CriarAtendimentoComponent } from './Pages/criar-atendimento/criar-atendimento.component';
import { MostrarAtendimentosComponent } from './Pages/mostrar-atendimentos/mostrar-atendimentos.component';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MatIconModule } from '@angular/material/icon';
import { HeaderComponent } from './Pages/header/header.component';
import { LoginComponent } from './Pages/login/login.component';
import { LoadingSpinnerComponent } from './Pages/loading-spinner/loading-spinner.component';
import { AngularFireModule } from '@angular/fire/compat';
import { PrincipalComponent } from './Pages/principal/principal.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'principal', component: PrincipalComponent },
  { path: 'adicionarAtendimento', component: CriarAtendimentoComponent },
  { path: 'listarAtendimentos', component: MostrarAtendimentosComponent },
  { path: 'editarAtendimento/:id', component: EditarAtendimentoComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' }
];
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    EditarAtendimentoComponent,
    CriarAtendimentoComponent,
    MostrarAtendimentosComponent,
    HeaderComponent,
    LoadingSpinnerComponent,
    PrincipalComponent
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
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    MatIconModule,
    AngularFireModule.initializeApp(
      {
        apiKey: "AIzaSyCdIqHBXcreClY_Y2TTWZ1KZ3_4jndjIHs",
        authDomain: "petshop-b2745.firebaseapp.com",
        databaseURL: "https://petshop-b2745-default-rtdb.firebaseio.com",
        projectId: "petshop-b2745",
        storageBucket: "petshop-b2745.appspot.com",
        messagingSenderId: "1010830230324",
        appId: "1:1010830230324:web:c34434bc61f0a45ef05b61",
        measurementId: "G-50RV1WLY9G"
      }
    ),
    RouterModule.forRoot(routes)
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
