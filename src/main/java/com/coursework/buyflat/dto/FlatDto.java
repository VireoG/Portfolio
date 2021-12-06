package com.coursework.buyflat.dto;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class FlatDto {
    private StreetDto street;
    private BathroomDto bathroom;
    private RoomDto room;
    private String numberFlat;
    private Double area;
}
