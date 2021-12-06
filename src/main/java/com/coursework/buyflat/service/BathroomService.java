package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.BathroomDto;
import com.coursework.buyflat.mapper.BathroomMapper;
import com.coursework.buyflat.repo.BathroomRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class BathroomService {
    private final BathroomRepo repo;
    private final BathroomMapper mapper;

    public List<BathroomDto> getAll() {
        return mapper.bathroomsToDtos(repo.findAll());
    }
}
