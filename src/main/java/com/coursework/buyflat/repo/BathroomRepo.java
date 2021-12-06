package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.BathroomEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BathroomRepo extends JpaRepository<BathroomEntity, Long> {
    BathroomEntity findByBathroomName(String bathroomName);
}
