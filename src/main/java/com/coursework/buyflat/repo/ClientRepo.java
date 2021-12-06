package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.ClientEntity;
import com.coursework.buyflat.entity.UserEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface ClientRepo extends JpaRepository<ClientEntity, Long> {
    Optional<ClientEntity> findByUser(UserEntity user);
}
