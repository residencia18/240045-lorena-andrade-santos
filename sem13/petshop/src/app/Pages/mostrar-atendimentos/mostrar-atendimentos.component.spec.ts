import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MostrarAtendimentosComponent } from './mostrar-atendimentos.component';

describe('MostrarAtendimentosComponent', () => {
  let component: MostrarAtendimentosComponent;
  let fixture: ComponentFixture<MostrarAtendimentosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [MostrarAtendimentosComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MostrarAtendimentosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
