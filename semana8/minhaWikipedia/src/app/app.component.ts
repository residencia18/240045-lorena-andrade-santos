// app.component.ts
import { Component } from '@angular/core';
import { WikipediaService } from './wikipedia-service.service';

import { Result  } from './resultado-pesquisa/resultado-pesquisa.component'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'minhaWikipedia';
  results: Result[] = [];
  
  term = '';

  onResultsChange(results: Result[]) {
    this.results = results;
  }
  // title = 'minhaWikipedia';
  // results = [];
  // term = '';

  // constructor(private wikipedia: WikipediaService) {}

  // onTermChange(term: string) {
  //   this.term = term;
  // }

  // onSearchClick() {
  //   console.log("Searching for:", this.term);

  //   if (this.term.trim() !== '') {
  //     this.wikipedia.pesquisar(this.term).subscribe(
  //       (response: any) => {
  //         this.results = response.query.search;
  //       },
  //       (error) => {
  //         console.error('Error during Wikipedia search:', error);
  //       }
  //     );
  //   }
  // }
}
