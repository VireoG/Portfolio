package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.RegionDto;
import com.coursework.buyflat.entity.RegionEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface RegionMapper {
    List<RegionDto> regionsToDtos(List<RegionEntity> regions);

}
