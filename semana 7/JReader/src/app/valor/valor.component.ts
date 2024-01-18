// valor.component.ts
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-valor',
  templateUrl: './valor.component.html',
  styleUrls: ['./valor.component.css']
})
export class ValorComponent {
  @Input() valor: any;
}
