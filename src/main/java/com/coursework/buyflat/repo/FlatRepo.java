package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.FlatEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface FlatRepo extends JpaRepository<FlatEntity, Long> {
}
