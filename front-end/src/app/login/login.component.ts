import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit {

  submitting = false
  errorMessage: string = ''

  email: string = '';
  password: string = '';

  setEmail(e: any) {
    this.email = e
  }

  setPassword(e: any) {
    this.password = e
  }

  constructor(private authService: AuthService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.email = params['email'] || '';
    });
  }

  login(): void {
    this.submitting = true
    this.authService.loginUser(this.email, this.password).subscribe({
      complete: () => {
        this.router.navigate(['/home']);
      },
      error: () => {
        console.error("Login failed");
      }
    });
    this.submitting = false
  }
}
