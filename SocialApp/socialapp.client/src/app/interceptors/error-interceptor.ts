import { Injectable } from '@angular/core';
import {
  HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpErrorResponse
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(req).pipe(
      catchError((error: HttpErrorResponse) => {

        if (error.status === 0) {
          console.error('API unreachable');
          alert('Failed to connect to the server. Please ensure the API is running and try again.');
        }

        if (error.status === 401) {
          console.warn('Unauthorized');
        }

        if (error.status >= 500) {
          console.error('Server error');
        }

        return throwError(() => error);
      })
    );
  }
}