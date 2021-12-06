package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.CreateFlatDto;
import com.coursework.buyflat.entity.*;
import com.coursework.buyflat.repo.*;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
public class FlatService {
    private final RoomRepo roomRepo;
    private final RegionRepo regionRepo;
    private final StreetRepo streetRepo;
    private final FlatRepo flatRepo;
    private final CityRepo cityRepo;
    private final BathroomRepo bathroomRepo;

    public FlatEntity createFlat(CreateFlatDto flatDto) {
        CityEntity city = cityRepo.findByCityName(flatDto.getCityDto().getCityName()).orElseThrow(() -> new RuntimeException());
        RegionEntity region = regionRepo.findByCity(city).orElseThrow(() -> new RuntimeException());
        StreetEntity street = streetRepo.findByRegion(region).orElseThrow(() -> new RuntimeException());
        FlatEntity flat = FlatEntity.builder()
                .id(flatDto.getFlatId())
                .street(street)
                .numberFlat(flatDto.getNumberFlat())
                .area(flatDto.getArea())
                .room(roomRepo.getByCountRooms(flatDto.getRoom().getCountRooms()))
                .bathroom(bathroomRepo.findByBathroomName(flatDto.getBathroom().getBathroomName()))
                .build();
        return flatRepo.save(flat);
    }
}
