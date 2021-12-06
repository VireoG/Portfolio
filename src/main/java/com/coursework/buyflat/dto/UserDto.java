package com.coursework.buyflat.dto;

import com.coursework.buyflat.entity.Role;
import com.coursework.buyflat.entity.UserType;
import lombok.*;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class UserDto {
    private String firstName;

    private String middleName;

    private String lastName;

    private String phone;

    private String email;

    private String password;

    private Integer age;

    private UserType type;

    private Role role;
}
