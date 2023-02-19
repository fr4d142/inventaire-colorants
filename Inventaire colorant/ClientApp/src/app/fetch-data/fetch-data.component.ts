import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public inventaireColorants: InventaireColorant[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<InventaireColorant[]>(baseUrl + 'weatherforecast').subscribe(result => {
      this.inventaireColorants = result;
    }, error => console.error(error));
  }
}

interface InventaireColorant {
  date: string;
  quantite: number;
  nom: string;
  sku: string;
}
