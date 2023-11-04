import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PontuacoesComponent } from './pontuacoes.component';

describe('PontuacoesComponent', () => {
  let component: PontuacoesComponent;
  let fixture: ComponentFixture<PontuacoesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PontuacoesComponent]
    });
    fixture = TestBed.createComponent(PontuacoesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
