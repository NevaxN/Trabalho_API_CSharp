import { TestBed } from '@angular/core/testing';

import { GeneroUsuariosService } from './genero-usuarios.service';

describe('GeneroUsuariosService', () => {
  let service: GeneroUsuariosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GeneroUsuariosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
