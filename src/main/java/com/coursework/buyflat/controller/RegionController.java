package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.RegionDto;
import com.coursework.buyflat.service.RegionService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/region")
@RequiredArgsConstructor
public class RegionController {
    private final RegionService regionService;

    @GetMapping
    public List<RegionDto> getRegion() {
        return regionService.getAll();
    }
}
