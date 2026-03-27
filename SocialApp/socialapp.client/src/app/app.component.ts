import { Component } from '@angular/core';
import { UserProfile } from './interfaces/user-profile.interface';
import { UserService } from './services/user.service';

@Component({
  selector: 'app-root',
  standalone: false,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  profile: UserProfile | null = null;
  loading = false;
  error: string | null = null;

  constructor(private userService: UserService) {}

  connect(provider: string) {
    this.loading = true;
    this.error = null;

    this.userService.connect(provider)
      .subscribe({
          next: (data) => {
            this.profile = data;
            this.loading = false;
          },
          error: () => {
            this.error = 'Failed to connect. Please try again.';
            this.loading = false;
          }
        });
  }

  logout() {
    this.profile = null;
  }
}
