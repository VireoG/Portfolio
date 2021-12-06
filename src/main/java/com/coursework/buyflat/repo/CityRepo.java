package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.CityEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface CityRepo extends JpaRepository<CityEntity, Long> {
    Optional<CityEntity> findByCityName(String cityName);
}
