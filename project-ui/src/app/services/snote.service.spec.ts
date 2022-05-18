import { TestBed } from '@angular/core/testing';

import { SnoteService } from './snote.service';

describe('SnoteService', () => {
  let service: SnoteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SnoteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
