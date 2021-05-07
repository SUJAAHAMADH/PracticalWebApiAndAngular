import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TemperatureconversiondetailComponent } from './components/temperatureconversiondetail/temperatureconversiondetail.component';

const routes: Routes = [
  { path: '', redirectTo: 'temperatureconversiondetail', pathMatch: 'full' },
  { path: 'temperatureconversiondetail', component: TemperatureconversiondetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
