package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.StreetDto;
import com.coursework.buyflat.mapper.StreetMapper;
import com.coursework.buyflat.repo.StreetRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class StreetService {
    private final StreetMapper mapper;
    private final StreetRepo repo;

    public List<StreetDto> getAll() {
        return mapper.streetsToDtos(repo.findAll());
    }
}
