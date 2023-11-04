import { TestBed } from '@angular/core/testing';

import { CatalogoFilmesService } from './catalogo-filmes.service';

describe('CatalogoFilmesService', () => {
  let service: CatalogoFilmesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CatalogoFilmesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
