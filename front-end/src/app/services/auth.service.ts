import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { BehaviorSubject, catchError, map, Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  backendUrl = environment.backendUrl;

  private tokenKey = 'accessToken';

  private authenticated$ = new BehaviorSubject<boolean>(this.hasToken());

  constructor(private http: HttpClient) { }

  private hasToken(): boolean {
    return typeof localStorage !== 'undefined' ? !!localStorage.getItem(this.tokenKey) : false;
  }

  getToken(): string | null {
    return typeof localStorage !== 'undefined' ? localStorage.getItem(this.tokenKey) : null;
  }

  get isAuthenticated(): Observable<boolean> {
    return this.authenticated$.asObservable();
  }

  registerUser(email: string, password: string): Observable<any> {
    return this.http.post<any>(`${this.backendUrl}register`, { email, password });
  }

  loginUser(email: string, password: string): Observable<any> {
    return this.http.post<{ tokenType: String, accessToken: string, expiresIn: string, refreshToken: string }>(`${this.backendUrl}login`, { email, password }).pipe(
      map(response => {
        localStorage.setItem(this.tokenKey, response.accessToken);
        this.authenticated$.next(true);
      })
    );
  }

  logout(): void {
    localStorage.removeItem(this.tokenKey);
    this.authenticated$.next(false);
  }

}
