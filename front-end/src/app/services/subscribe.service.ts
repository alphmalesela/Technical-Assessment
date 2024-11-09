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

  getSubscriptions(): Observable<Subscription[]> {
    return this.http.get<Subscription[]>(this.apiURLSubscriptions);
  }

  getSubscription(id: number): Observable<Subscription> {
    return this.http.get<Subscription>(this.apiURLSubscriptions + '/' + id);
  }
}
