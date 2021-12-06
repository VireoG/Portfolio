package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.BathroomDto;
import com.coursework.buyflat.entity.BathroomEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface BathroomMapper {
    List<BathroomDto> bathroomsToDtos(List<BathroomEntity> bathrooms);
}
