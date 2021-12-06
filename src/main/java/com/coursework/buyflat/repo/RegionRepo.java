package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.CityEntity;
import com.coursework.buyflat.entity.RegionEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface RegionRepo extends JpaRepository<RegionEntity, Long> {
    Optional<RegionEntity> findByCity(CityEntity city);
}
