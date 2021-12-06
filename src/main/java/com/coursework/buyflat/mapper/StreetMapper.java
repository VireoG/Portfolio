package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.StreetDto;
import com.coursework.buyflat.entity.StreetEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface StreetMapper {
    List<StreetDto> streetsToDtos(List<StreetEntity> streets);

}
