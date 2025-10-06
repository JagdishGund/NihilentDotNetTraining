import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

 fullName: string = '';
  email: string = '';
  password: string = '';
  errorMessage: string = '';

constructor(){}

  onRegister() {
    this.errorMessage = '';

    // Basic validation
    if (!this.fullName.trim()) {
      this.errorMessage = 'Full name is required.';
      return;
    }

    if (!this.email.trim()) {
      this.errorMessage = 'Email is required.';
      return;
    }

    if (!this.validateEmail(this.email)) {
      this.errorMessage = 'Please enter a valid email address.';
      return;
    }

    if (!this.password) {
      this.errorMessage = 'Password is required.';
      return;
    }

    if (this.password.length < 6) {
      this.errorMessage = 'Password must be at least 6 characters long.';
      return;
    }

    // TODO: Replace with API call
    console.log('Registering user:', {
      fullName: this.fullName,
      email: this.email,
      password: this.password
    });

    alert('Registration successful! 🎉');
    
    // Reset form
    this.fullName = '';
    this.email = '';
    this.password = '';
  }

  private validateEmail(email: string): boolean {
    const re = /^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$/;
    return re.test(email.toLowerCase());
  }

}
