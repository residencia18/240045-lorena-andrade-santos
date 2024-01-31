import { Component, OnInit } from '@angular/core';
import { RedirectServiceService } from '../redirect-service.service';

@Component({
  selector: 'app-minha-wikipedia',
  templateUrl: './minha-wikipedia.component.html',
  styleUrl: './minha-wikipedia.component.css'
})
export class MinhaWikipediaComponent  implements OnInit {

  constructor(private redirectService: RedirectServiceService) { }

  ngOnInit(): void {
    this.redirectService.redirectToWikipedia();
  }
}
