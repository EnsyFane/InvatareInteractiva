import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SnotePageComponent } from './snote-page.component';

describe('SnotePageComponent', () => {
  let component: SnotePageComponent;
  let fixture: ComponentFixture<SnotePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SnotePageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SnotePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
