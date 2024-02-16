import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VeiculoCategoriasComponent } from './veiculo-categorias.component';

describe('VeiculoCategoriasComponent', () => {
  let component: VeiculoCategoriasComponent;
  let fixture: ComponentFixture<VeiculoCategoriasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [VeiculoCategoriasComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(VeiculoCategoriasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
