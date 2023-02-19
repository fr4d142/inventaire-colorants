import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0;
    public httpClient;
  public baseUrl;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpClient = http;
      this.baseUrl = baseUrl
    }

  public incrementCounter() {
    this.currentCount++;
  }
}
