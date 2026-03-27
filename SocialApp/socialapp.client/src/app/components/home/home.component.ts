import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent {
  @Output() connectProvider = new EventEmitter<string>();

  connect(provider: string) {
    this.connectProvider.emit(provider);
  }
}
