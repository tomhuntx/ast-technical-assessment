import { Component, Input, Output, EventEmitter } from '@angular/core';

// TODO: use @interfaces
import { UserProfile } from '../../interfaces/user-profile.interface';

@Component({
  selector: 'app-profile',
  standalone: false,
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css',
})
export class ProfileComponent {
  @Input() profile!: UserProfile;
  @Output() logoutEvent = new EventEmitter<void>();

  logout() {
    this.logoutEvent.emit();
  }
}
