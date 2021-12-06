package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.RealtorEntity;
import com.coursework.buyflat.entity.UserEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface RealtorRepo extends JpaRepository<RealtorEntity, Long> {
    Optional<RealtorEntity> findByUser(UserEntity user);
}
