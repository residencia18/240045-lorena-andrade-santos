import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class RedirectServiceService {

  constructor(private router: Router) { }

  redirectToUESC(): void {
    window.location.href = 'https://lorenaandradeba.github.io/tic18_M2_Front/semana6/UESC-app/dist/uesc-app/browser/UESC-app/';
  }

  redirectToJReader(): void {
    window.location.href = 'https://lorenaandradeba.github.io/tic18_M2_Front/semana%207/JReader/dist/jreader/browser/JReader/';
  }

  redirectToWikipedia(): void {
    window.location.href = 'https://lorenaandradeba.github.io/tic18_M2_Front/semana8/minhaWikipedia/dist/minha-wikipedia/browser/minhaWikipedia/';
  }
}
