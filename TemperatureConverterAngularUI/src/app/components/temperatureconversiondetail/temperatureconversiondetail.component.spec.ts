import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TemperatureconversiondetailComponent } from './temperatureconversiondetail.component';

describe('TemperatureconversiondetailComponent', () => {
  let component: TemperatureconversiondetailComponent;
  let fixture: ComponentFixture<TemperatureconversiondetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TemperatureconversiondetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TemperatureconversiondetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
