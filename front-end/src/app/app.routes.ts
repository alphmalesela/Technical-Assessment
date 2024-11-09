import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { BookComponent } from './book/book.component';
import { SubscriptionsComponent } from './subscriptions/subscriptions.component';
import { SubscriptionComponent } from './subscription/subscription.component';
import { ConfirmSubscriptionComponent } from './confirm-subscription/confirm-subscription.component';
import { SuccessfulSubscriptionComponent } from './successful-subscription/successful-subscription.component';

export const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'subscriptions', component: SubscriptionsComponent },
  { path: 'login', component: LoginComponent },
  { path: 'book/:id', component: BookComponent },
  { path: 'subscription/:id', component: SubscriptionComponent },
  { path: 'confirm-subscription/:id', component: ConfirmSubscriptionComponent },
  { path: 'successful-subscription', component: SuccessfulSubscriptionComponent },
];
