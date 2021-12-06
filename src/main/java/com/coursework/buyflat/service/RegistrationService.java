package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.RegistrationDto;
import com.coursework.buyflat.entity.*;
import com.coursework.buyflat.repo.ClientRepo;
import com.coursework.buyflat.repo.RealtorRepo;
import com.coursework.buyflat.repo.UserRepo;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

@Slf4j
@Service
@RequiredArgsConstructor
public class RegistrationService {
    private final UserRepo userRepo;
    private final ClientRepo clientRepo;
    private final RealtorRepo realtorRepo;
    private final PasswordEncoder passwordEncoder;

    public void registerUser(RegistrationDto registrationDto) {
        if (emailExist(registrationDto.getEmail())) throw new RuntimeException();
        UserEntity user = UserEntity.builder()
                .firstName(registrationDto.getFirstName())
                .middleName(registrationDto.getMiddleName())
                .lastName(registrationDto.getLastName())
                .age(registrationDto.getAge())
                .phone(registrationDto.getPhone())
                .email(registrationDto.getEmail())
                .password(passwordEncoder.encode(registrationDto.getPassword()))
                .type(registrationDto.getType())
                .role(Role.USER)
                .build();
        userRepo.save(user);
        if (user.getType().equals(UserType.CLIENT)) {
            ClientEntity client = ClientEntity.builder()
                    .passport(registrationDto.getPassport())
                    .user(user)
                    .build();
            clientRepo.save(client);
        } else {
            RealtorEntity realtor = RealtorEntity.builder()
                    .percent(registrationDto.getPercent())
                    .user(user)
                    .build();
            realtorRepo.save(realtor);
        }
    }

    private boolean emailExist(String email) {
        return userRepo.findByEmail(email).isPresent();
    }
}
