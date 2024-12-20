import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Book } from '../models/book';
import { Observable } from 'rxjs';
import { Subscription } from '../models/subscription';

@Injectable({
  providedIn: 'root'
})
export class SubscribeService {
  apiURLSubscriptions = environment.apiUrl + 'Subscriptions';

  constructor(private http: HttpClient) { }

  addSubscription(bookId: number): Observable<Subscription[]> {
    return this.http.post<Subscription[]>(`${this.apiURLSubscriptions}/add`, {
      bookId
    });
  }

  getSubscriptions(): Observable<Subscription[]> {
    return this.http.get<Subscription[]>(this.apiURLSubscriptions);
  }

  getSubscription(id: number): Observable<Subscription> {
    return this.http.get<Subscription>(this.apiURLSubscriptions + '/' + id);
  }

  deleteSubscription(id: number): Observable<any> {
    return this.http.delete<any>(`${this.apiURLSubscriptions}/${id}`);
  }
}
