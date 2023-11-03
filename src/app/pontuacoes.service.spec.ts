import { TestBed } from '@angular/core/testing';

import { PontuacoesService } from './pontuacoes.service';

describe('PontuacoesService', () => {
  let service: PontuacoesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PontuacoesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
