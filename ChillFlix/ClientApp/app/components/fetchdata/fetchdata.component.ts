import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public movies: IMovie[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
            this.movies = result.json() as IMovie[];
        }, error => console.error(error));
    }
}

interface IMovie {
    Title: string;
    Link: number;
    Length: number;
}
