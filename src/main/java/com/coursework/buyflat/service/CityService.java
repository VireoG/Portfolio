package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.CityDto;
import com.coursework.buyflat.mapper.CityMapper;
import com.coursework.buyflat.repo.CityRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class CityService {
    private final CityRepo repo;
    private final CityMapper mapper;

    public List<CityDto> getAll() {
        return mapper.citiesToDtos(repo.findAll());
    }
}