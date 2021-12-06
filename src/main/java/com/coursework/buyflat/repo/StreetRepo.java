package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.RegionEntity;
import com.coursework.buyflat.entity.StreetEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface StreetRepo extends JpaRepository<StreetEntity, Long> {
    Optional<StreetEntity> findByRegion(RegionEntity region);
}
