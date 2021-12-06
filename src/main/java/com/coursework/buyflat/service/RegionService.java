package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.RegionDto;
import com.coursework.buyflat.mapper.RegionMapper;
import com.coursework.buyflat.repo.RegionRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@RequiredArgsConstructor
public class RegionService {
    private final RegionRepo repo;
    private final RegionMapper mapper;

    public List<RegionDto> getAll() {
        return mapper.regionsToDtos(repo.findAll());
    }
}