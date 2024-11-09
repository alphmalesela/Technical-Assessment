import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book';
import { SubscribeService } from '../services/subscribe.service';
import { Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Subscription } from '../models/subscription';

@Component({
  selector: 'app-subscriptions',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './subscriptions.component.html',
  styleUrl: './subscriptions.component.css'
})
export class SubscriptionsComponent implements OnInit {

  subs: Subscription[] = [];

  constructor(private subscribeService: SubscribeService, private router: Router) { }
  ngOnInit(): void {
    this.subscribeService.getSubscriptions().subscribe((subs) => {
      this.subs = subs;
    });
  }

}
