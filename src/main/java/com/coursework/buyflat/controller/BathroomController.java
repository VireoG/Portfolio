package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.BathroomDto;
import com.coursework.buyflat.service.BathroomService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/bathroom")
@RequiredArgsConstructor
public class BathroomController {
    private final BathroomService bathroomService;

    @GetMapping
    public List<BathroomDto> getBathrooms() {
        return bathroomService.getAll();
    }
}
