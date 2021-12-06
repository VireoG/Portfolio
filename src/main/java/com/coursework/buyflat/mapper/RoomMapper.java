package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.RoomDto;
import com.coursework.buyflat.entity.RoomEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface RoomMapper {
    List<RoomDto> roomsToDtos(List<RoomEntity> rooms);
}
