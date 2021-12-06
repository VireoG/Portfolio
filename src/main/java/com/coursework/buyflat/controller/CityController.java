package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.CityDto;
import com.coursework.buyflat.service.CityService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/city")
@RequiredArgsConstructor
public class CityController {
    private final CityService cityService;

    @GetMapping
    public List<CityDto> getCity() {
        return cityService.getAll();
    }
}
