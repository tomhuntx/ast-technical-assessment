import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { UserProfile } from '../interfaces/user-profile.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private http = inject(HttpClient);
  
  connect(provider: string): Observable<UserProfile> {
      return this.http.get<UserProfile>(`https://localhost:7114/login?provider=${provider}`);
    }
}
