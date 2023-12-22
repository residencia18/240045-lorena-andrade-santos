// central.component.ts

import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-central',
  templateUrl: './central.component.html',
  styleUrls: ['./central.component.css']
})
export class CentralComponent implements OnInit {
  joke: { setup: string; delivery: string } = { setup: '', delivery: '' };

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.fetchJoke();
  }

  fetchJoke(): void {
    const jokeApiUrl = 'https://v2.jokeapi.dev/joke/Any?lang=pt';
    this.http.get<any>(jokeApiUrl).subscribe(data => {
      this.joke = data;
    });
  }
}
