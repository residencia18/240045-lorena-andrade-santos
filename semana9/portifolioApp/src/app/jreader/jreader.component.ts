import { Component, OnInit } from '@angular/core';
import { RedirectServiceService } from '../redirect-service.service';

@Component({
  selector: 'app-jreader',
  templateUrl: './jreader.component.html',
  styleUrl: './jreader.component.css'
})
export class JReaderComponent  implements OnInit {

  constructor(private redirectService: RedirectServiceService) { }

  ngOnInit(): void {
    this.redirectService.redirectToJReader();
  }

}
