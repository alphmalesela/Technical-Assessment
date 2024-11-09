import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book';
import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from '../services/book.service';
import { SubscribeService } from '../services/subscribe.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-confirm-subscription',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './confirm-subscription.component.html',
  styleUrl: './confirm-subscription.component.css'
})
export class ConfirmSubscriptionComponent implements OnInit {

  book!: Book;

  submitting = false

  submittingFailed = false

  constructor(private bookService: BookService, private subscribeService: SubscribeService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.bookService.getBook(id).subscribe((book) => {
      this.book = book;
    });
  }

  addSubscription(): void {
    this.submitting = true
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.subscribeService.addSubscription(id).subscribe({
      complete: () => {
        this.router.navigate(['/successful-subscription']);
      },
      error: () => {
        this.submittingFailed = true
        console.error("Add subscription failed");
      }
    });
    this.submitting = false
  }
}
