import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { MycomponentsComponent } from './componets/mycomponents/mycomponents.component';
import { TemplateBindingComponent } from './componets/template/template-binding/template-binding.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, MycomponentsComponent, TemplateBindingComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'appNew';
}
