package com.coursework.buyflat.config;

import com.coursework.buyflat.entity.UserEntity;
import com.coursework.buyflat.exception.UserNotFoundException;
import com.coursework.buyflat.repo.UserRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Component;

import java.util.Optional;

@Component
@RequiredArgsConstructor
public class UserDetailServiceImpl implements UserDetailsService {
    private final UserRepo userRepo;

    @Override
    public UserDetails loadUserByUsername(String email) throws UsernameNotFoundException {
        Optional<UserEntity> userOptional = userRepo.findByEmail(email);
        return userOptional.orElseThrow(() -> new UserNotFoundException(email));
    }
}
