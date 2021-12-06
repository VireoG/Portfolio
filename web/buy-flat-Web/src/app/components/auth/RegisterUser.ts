import { AuthUser } from "./AuthUser";

export interface RegisterUser extends AuthUser {
  firstName: string ;
  middleName: string ;
  lastName: string ;
  phone: string ;
  age: number;
  type: string;
  percent: bigint;
  passport: string;
}
