import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  backendUrl = environment.backendUrl

  constructor(private http: HttpClient) { }

  registerUser(email: string, password: string): Observable<any> {
    return this.http.post<any>(`${this.backendUrl}register`, { email, password });
  }

  loginUser(email: string, password: string): Observable<any> {
    return this.http.post<any>(`${this.backendUrl}login`, { email, password }, {
      withCredentials: true,
      params: { useCookies: true, useSessionCookies: true }
    });
  }
}
