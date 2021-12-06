package com.coursework.buyflat.mapper;

import com.coursework.buyflat.dto.OrderDto;
import com.coursework.buyflat.entity.OrderEntity;
import org.mapstruct.Mapper;

import java.util.List;

@Mapper
public interface OrderMapper {
    OrderEntity dtoToOrder(OrderDto orderDto);
    OrderDto orderToDto (OrderEntity order);
   List<OrderDto> ordersToDtos(List<OrderEntity> order);
    List<OrderEntity> DtosToOrders(List<OrderDto> order);
}
