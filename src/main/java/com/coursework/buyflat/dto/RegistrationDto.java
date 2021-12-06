package com.coursework.buyflat.dto;

import com.coursework.buyflat.entity.UserType;
import lombok.*;

@Getter
@Setter
@Builder
@AllArgsConstructor
@NoArgsConstructor
public class RegistrationDto {
    private String firstName;
    private String middleName;
    private String lastName;
    private String phone;
    private Integer age;
    private String email;
    private String password;
    private UserType type;
    private Double percent;
    private String passport;
}
