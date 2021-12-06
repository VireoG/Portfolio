package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.StreetDto;
import com.coursework.buyflat.service.StreetService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/street")
@RequiredArgsConstructor
public class StreetController {
    private final StreetService streetService;

    @GetMapping
    public List<StreetDto> getStreet() {
        return streetService.getAll();
    }
}
