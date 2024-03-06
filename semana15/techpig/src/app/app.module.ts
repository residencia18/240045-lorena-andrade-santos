import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
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
import { HeaderComponent } from './Pages/header/header.component';
import { AngularFireModule } from '@angular/fire/compat';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule } from '@angular/material/icon';

//@angular/material
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';


const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'principal', component: PrincipalComponent },
  { path: 'cadastrarAnimal', component: CadastrarComponent },
  { path: 'listarAnimal', component: ListarComponent },
  { path: 'cadastrarPeso', component: CadastroPesoComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full' }
  //{ path: 'editarAnimal/:id', component: EditarComponent },
  // { path: 'editarPeso/:id',  component: EditarPesoComponent},
];
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
    ControlePesoComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCardModule,
    MatSelectModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatIconModule,
    AngularFireModule.initializeApp({
      apiKey: "AIzaSyB5w1o6q6kFHmEjJ1mao5AdPHHaX-dHv_Q",
      authDomain: "techpig-3d8dc.firebaseapp.com",
      projectId: "techpig-3d8dc",
      storageBucket: "techpig-3d8dc.appspot.com",
      messagingSenderId: "784692155056",
      appId: "1:784692155056:web:ea5ce8748eb9ac8e1a2175",
      measurementId: "G-64G0NBKRHS"
    }),
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
