import { Component, OnInit } from '@angular/core';
import { ConverterService } from '../../services/converter.service';
import { Temperature } from '../../models/temperature.model';
@Component({
  selector: 'app-temperatureconversiondetail',
  templateUrl: './temperatureconversiondetail.component.html',
  styleUrls: ['./temperatureconversiondetail.component.css']
})
export class TemperatureconversiondetailComponent implements OnInit {

  constructor(private converterService: ConverterService) { }
  temperature: Temperature;
  userselection:string;
  value:any;
  isCelsiusCoversion:boolean;
  isKelvinCoversion:boolean;
  isFahrenheitCoversion:boolean;

  ngOnInit() {
  }
  getConvertedData(): void {
    this.converterService.get(this.userselection,this.value)
      .subscribe(
        data => {
          this.temperature = data;
          if(this.temperature.celsius ==null)
          {
            this.temperature.celsius=0;
            this.isCelsiusCoversion=false;
            this.isFahrenheitCoversion=true;
            this.isKelvinCoversion=true;
          }
          if(this.temperature.kelvin ==null)
          {
            this.temperature.kelvin=0;
            this.isKelvinCoversion=false;
            this.isCelsiusCoversion=true;
            this.isFahrenheitCoversion=true;
          }
          if(this.temperature.fahrenheit ==null)
          {
            this.temperature.fahrenheit=0;
            this.isFahrenheitCoversion=false;
            this.isKelvinCoversion=true;
            this.isCelsiusCoversion=true;
          }
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
}
