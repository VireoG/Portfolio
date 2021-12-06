package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.RoomDto;
import com.coursework.buyflat.service.RoomService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/room")
@RequiredArgsConstructor
public class RoomController {
    private final RoomService roomService;

    @GetMapping
    public List<RoomDto> getRooms() {
        return roomService.getAll();
    }
}
