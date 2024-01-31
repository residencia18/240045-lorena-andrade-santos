import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UESCAppComponent } from './uesc-app/uesc-app.component';
import { JReaderComponent } from './jreader/jreader.component';
import { MinhaWikipediaComponent } from './minha-wikipedia/minha-wikipedia.component';
const routes: Routes = [
  { path: 'uesc', component: UESCAppComponent },
  { path: 'jreader', component: JReaderComponent },
  { path: 'wikipedia', component: MinhaWikipediaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
