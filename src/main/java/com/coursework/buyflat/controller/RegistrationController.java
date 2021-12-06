package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.RegistrationDto;
import com.coursework.buyflat.service.RegistrationService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/registration")
@RequiredArgsConstructor
public class RegistrationController {
    private final RegistrationService registrationService;

    @PostMapping
    public void registerUser(@RequestBody RegistrationDto registrationDto) {
        registrationService.registerUser(registrationDto);
    }
}
