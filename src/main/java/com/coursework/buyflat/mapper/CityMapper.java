package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.CityDto;
import com.coursework.buyflat.entity.CityEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface CityMapper {
    List<CityDto> citiesToDtos(List<CityEntity> cities);
}
