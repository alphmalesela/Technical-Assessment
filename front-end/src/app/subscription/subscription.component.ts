import { Component, OnInit } from '@angular/core';
import { Subscription } from '../models/subscription';
import { SubscribeService } from '../services/subscribe.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-subscription',
  standalone: true,
  imports: [],
  templateUrl: './subscription.component.html',
  styleUrl: './subscription.component.css'
})
export class SubscriptionComponent implements OnInit {
  subscription!: Subscription;

  constructor(private subscribeService: SubscribeService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.subscribeService.getSubscription(id).subscribe((subscription) => {
      this.subscription = subscription;
    });
  }
}
