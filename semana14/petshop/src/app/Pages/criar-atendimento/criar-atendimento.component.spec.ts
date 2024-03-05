import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriarAtendimentoComponent } from './criar-atendimento.component';

describe('CriarAtendimentoComponent', () => {
  let component: CriarAtendimentoComponent;
  let fixture: ComponentFixture<CriarAtendimentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CriarAtendimentoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CriarAtendimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
