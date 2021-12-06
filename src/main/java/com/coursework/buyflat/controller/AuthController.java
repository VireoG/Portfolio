package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.AuthDto;
import com.coursework.buyflat.dto.TokenDto;
import com.coursework.buyflat.service.AuthService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/auth")
@RequiredArgsConstructor
public class AuthController {
    private final AuthService authService;

    @PostMapping
    public TokenDto auth(@RequestBody AuthDto authDto) {
        return authService.auth(authDto);
    }
}
