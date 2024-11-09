import { Component, OnInit } from '@angular/core';
import { BookService } from '../services/book.service';
import { SubscribeService } from '../services/subscribe.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from '../models/subscription';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-confirm-cancellation',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './confirm-cancellation.component.html',
  styleUrl: './confirm-cancellation.component.css'
})
export class ConfirmCancellationComponent implements OnInit {

  subscription!: Subscription;

  submitting = false

  submittingFailed = false

  constructor(private subscribeService: SubscribeService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.subscribeService.getSubscription(id).subscribe((subscription) => {
      this.subscription = subscription;
    });
  }

  cancelSubscription(): void {
    this.submitting = true
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.subscribeService.deleteSubscription(id).subscribe({
      complete: () => {
        this.router.navigate(['/successful-cancellation']);
      },
      error: () => {
        this.submittingFailed = true
        console.error("Add subscription failed");
      }
    });
    this.submitting = false
  }

}
