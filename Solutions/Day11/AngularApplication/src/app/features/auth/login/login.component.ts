import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../../core/services/auth.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  email = '';
  password = '';
  errorMessage = '';

  constructor(private authService: AuthService, private router: Router) {}

  onLogin() {
    const success = this.authService.login(this.email, this.password);
    if (success) {
      this.router.navigate(['/products']); // redirect to products after login
    } else {
      this.errorMessage = 'Invalid credentials';
    }
  }
}
