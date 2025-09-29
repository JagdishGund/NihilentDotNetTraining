import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private readonly TOKEN_KEY = 'auth_token';

  constructor() {}

  // Simulate login → normally you’d call backend API here
  login(email: string, password: string): boolean {
    // For demo: accept any non-empty credentials
    if (email && password) {
      localStorage.setItem(this.TOKEN_KEY, 'dummy-jwt-token'); 
      return true;
    }
    return false;
  }

  // Check if user is logged in
  isLoggedIn(): boolean {
    return !!localStorage.getItem(this.TOKEN_KEY);
  }

  // Get token (if using JWT in backend)
  getToken(): string | null {
    return localStorage.getItem(this.TOKEN_KEY);
  }

  // Logout
  logout(): void {
    localStorage.removeItem(this.TOKEN_KEY);
  }
}
