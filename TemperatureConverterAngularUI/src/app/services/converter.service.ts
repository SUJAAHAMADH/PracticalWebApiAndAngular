import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Temperature } from '../models/temperature.model';

const baseUrl = 'https://localhost:44387/api/TemperatureConvert/temperature';

@Injectable({
  providedIn: 'root'
})
export class ConverterService {
  constructor(private http: HttpClient) { }

  get(userselection: any,value:any):Observable<Temperature> { 
    var result= this.http.get<Temperature>(`${baseUrl}/${userselection}/${value}`);
    console.log(result._subscribe);
    return result;
  }
}
