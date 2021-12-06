import {Injectable} from '@angular/core';
import {AuthUser} from '../components/auth/AuthUser';
import {HttpClient} from '@angular/common/http';
import {SERVER_PATH} from '../../globals';
import {Observable} from 'rxjs';
import {AuthResponse} from '../components/auth/AuthResponse';
import {User} from '../dto/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) {
  }

  authenticate(authUser: AuthUser): Observable<AuthResponse> {
    return this.http.post<AuthResponse>(SERVER_PATH + '/auth', authUser);
  }

  validate(lsToken: string): Observable<User> {
    return this.http.post<User>(SERVER_PATH + '/auth', null, {
      headers: {
        Authorization: 'Bearer ' + lsToken
      }
    });
  }

}
