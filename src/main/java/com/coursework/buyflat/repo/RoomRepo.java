package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.RoomEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface RoomRepo extends JpaRepository<RoomEntity, Long> {
    RoomEntity getByCountRooms(Integer countRooms);
}
