package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.RoomDto;
import com.coursework.buyflat.mapper.RoomMapper;
import com.coursework.buyflat.repo.RoomRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class RoomService {
    private final RoomRepo repo;
    private final RoomMapper mapper;

    public List<RoomDto> getAll() {
        return mapper.roomsToDtos(repo.findAll());
    }
}
