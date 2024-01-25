//fazer-apesquisa.component.ts
import { Component, EventEmitter, Output } from '@angular/core';
import { WikipediaService } from '../wikipedia-service.service';
import { Result } from '../resultado-pesquisa/resultado-pesquisa.component';
@Component({
  selector: 'app-fazer-apesquisa',
  templateUrl: './fazer-apesquisa.component.html',
  styleUrl: './fazer-apesquisa.component.css'
})
export class FazerAPesquisaComponent {
  
  @Output() resultsChange = new EventEmitter<Result[]>();

  term = '';

  constructor(private wikipedia: WikipediaService) {}

  onInputChange(event: Event) {
    const target = event.target as HTMLInputElement;
    this.term = target.value;
  }

  onSearchClick() {
    if (this.term.trim() !== '') {
      this.wikipedia.pesquisar(this.term).subscribe(
        (response: any) => {
          this.resultsChange.emit(response.query.search);
        },
        (error) => {
          console.error('Error during Wikipedia search:', error);
        }
      );
    }
  }
}
