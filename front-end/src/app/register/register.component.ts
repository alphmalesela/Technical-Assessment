import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  submitting = false
  errorMessage: string = ''

  email: string = ''
  password: string = ''
  confirmPassword: string = ''

  setEmail(e: any) {
    this.email = e
  }

  setPassword(e: any) {
    this.password = e
  }

  setConfirmPassword(e: any) {
    this.confirmPassword = e
  }

  constructor(private authService: AuthService, private router: Router) { }

  register(): void {
    this.submitting = true

    if (this.password !== this.confirmPassword) {
      this.errorMessage = "Passwords do not match"
      return
    }

    this.authService.registerUser(this.email, this.password).subscribe({
      complete: () => {
        this.router.navigate(['/login'], { queryParams: { email: this.email } });
      },
      error: () => {
        console.error("Registration failed");
      }
    });

    this.submitting = false
  }
}
