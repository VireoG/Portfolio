package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.AuthDto;
import com.coursework.buyflat.dto.TokenDto;
import com.coursework.buyflat.entity.UserEntity;
import com.coursework.buyflat.jwt.JwtProvider;
import com.coursework.buyflat.repo.UserRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDate;

@Service
@RequiredArgsConstructor
public class AuthService {
    private final UserRepo userRepo;
    private final PasswordEncoder passwordEncoder;
    private final JwtProvider jwtProvider;

    public TokenDto auth(AuthDto authDto) {
        UserEntity user = userRepo.findByEmail(authDto.getEmail()).orElseThrow(() -> new RuntimeException(String.format("%s", authDto.getEmail())));
        if (passwordEncoder.matches(authDto.getPassword(), user.getPassword())) {
            return new TokenDto(jwtProvider.generateToken(user.getEmail()));
        }
        throw  new RuntimeException();
    }
}
