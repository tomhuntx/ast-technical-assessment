import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { UserProfile } from '../interfaces/user-profile.interface';
import { catchError, Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private http = inject(HttpClient);
  
connect(provider: string): Observable<UserProfile | null> {
  return this.http
    .get<UserProfile>(`https://localhost:7114/login?provider=${provider}`)
    .pipe(
      catchError(error => {
        console.error('Login request failed', error);

        // Just return nothing for now
        return of(null);
      })
    );
  }
}
