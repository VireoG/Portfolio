package com.coursework.buyflat.service;

import com.coursework.buyflat.entity.UserEntity;
import com.coursework.buyflat.exception.UserNotFoundException;
import com.coursework.buyflat.repo.UserRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class AuthenticationService {
    private final UserRepo userRepo;

    public UserEntity getUser() {
        UserDetails userDetails = (UserDetails) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
        String username = userDetails.getUsername();
        return userRepo.findByEmail(username).orElseThrow(() -> new UserNotFoundException(username));
    }
}