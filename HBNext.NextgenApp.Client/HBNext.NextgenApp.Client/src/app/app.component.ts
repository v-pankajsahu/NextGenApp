import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  /*public forecasts?: WeatherForecast[];*/
  public incidentsVal?: Incidents[];

  constructor(http: HttpClient) {
    http.get<Incidents[]>('/incident').subscribe(result => {
      this.incidentsVal = result;
    }, error => console.error(error));
  }

  title = 'HBNext.NextgenApp.Client';
}

interface Incidents {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
