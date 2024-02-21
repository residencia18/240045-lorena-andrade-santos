import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-binding',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './template-binding.component.html',
  styleUrl: './template-binding.component.css'
})
export class TemplateBindingComponent {
public name = 'Meu nome';
public age = 41;

public isDislabled = true;
public caminho = 'https://th.bing.com/th/id/R.59563770b3566d94d1ea6fed82be2cd9?rik=2CR3alXYicRjqg&riu=http%3a%2f%2fst2.depositphotos.com%2f1000423%2f9321%2fi%2f950%2fdepositphotos_93214286-stock-photo-up-the-career-ladder-overcoming.jpg&ehk=cSrBL98UOALJsI3mkYw83yF8p30JG3qpm5m2LknSv4k%3d&risl=&pid=ImgRaw&r=0';
constructor(){
  setTimeout(() => {
    this.name = "Ops mudei meu nome";
  }, 5000);

}

public sum(){
  return this.age++;
}
public sub(){
  return this.age--;
}

public onKeyDown(event: Event){
  return console.log(event);

}

public onMouse(event: MouseEvent){
  return console.log({
    x: event.clientX,
    y: event.clientY
  });

}
}
