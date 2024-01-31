import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UESCAppComponent } from './uesc-app/uesc-app.component';
import { JReaderComponent } from './jreader/jreader.component';
import { MinhaWikipediaComponent } from './minha-wikipedia/minha-wikipedia.component';
const routes: Routes = [
  { path: 'uesc', redirectTo: 'https://lorenaandradeba.github.io/tic18_M2_Front/', pathMatch: 'full' },
  { path: 'jreader', redirectTo:'https://lorenaandradeba.github.io/tic18_M2_Front/semana%207/JReader/dist/jreader/browser/JReader/', pathMatch: 'full' },
  { path: 'wikipedia',  redirectTo: 'https://lorenaandradeba.github.io/tic18_M2_Front/semana8/minhaWikipedia/dist/minha-wikipedia/browser/minhaWikipedia/', pathMatch: 'full'  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
