import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuccessfulCancellationComponent } from './successful-cancellation.component';

describe('SuccessfulCancellationComponent', () => {
  let component: SuccessfulCancellationComponent;
  let fixture: ComponentFixture<SuccessfulCancellationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SuccessfulCancellationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SuccessfulCancellationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
