import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FazerAPesquisaComponent } from './fazer-apesquisa.component';

describe('FazerAPesquisaComponent', () => {
  let component: FazerAPesquisaComponent;
  let fixture: ComponentFixture<FazerAPesquisaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [FazerAPesquisaComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FazerAPesquisaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
