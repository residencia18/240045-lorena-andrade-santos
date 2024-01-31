import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MinhaWikipediaComponent } from './minha-wikipedia.component';

describe('MinhaWikipediaComponent', () => {
  let component: MinhaWikipediaComponent;
  let fixture: ComponentFixture<MinhaWikipediaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MinhaWikipediaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MinhaWikipediaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
