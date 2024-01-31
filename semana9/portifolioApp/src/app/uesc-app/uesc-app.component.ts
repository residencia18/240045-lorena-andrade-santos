import { Component, OnInit } from '@angular/core';
import { RedirectServiceService } from '../redirect-service.service';

@Component({
  selector: 'app-uesc-app',
  templateUrl: './uesc-app.component.html',
  styleUrl: './uesc-app.component.css'
})
export class UESCAppComponent  implements OnInit {

  constructor(private redirectService: RedirectServiceService) { }

  ngOnInit(): void {
    this.redirectService.redirectToUESC();
  }

}
