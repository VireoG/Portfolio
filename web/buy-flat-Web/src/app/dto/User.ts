import { RegisterUser } from "../components/auth/RegisterUser";

export interface User extends RegisterUser { 
  id: number;
}
