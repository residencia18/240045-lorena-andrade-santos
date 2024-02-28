import { TestBed } from '@angular/core/testing';

import { FormEventosService } from './form-eventos.service';

describe('FormEventosService', () => {
  let service: FormEventosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FormEventosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
