import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConfirmCancellationComponent } from './confirm-cancellation.component';

describe('ConfirmCancellationComponent', () => {
  let component: ConfirmCancellationComponent;
  let fixture: ComponentFixture<ConfirmCancellationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConfirmCancellationComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConfirmCancellationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
