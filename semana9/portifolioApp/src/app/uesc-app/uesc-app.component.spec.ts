import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UESCAppComponent } from './uesc-app.component';

describe('UESCAppComponent', () => {
  let component: UESCAppComponent;
  let fixture: ComponentFixture<UESCAppComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [UESCAppComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UESCAppComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
