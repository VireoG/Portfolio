package com.coursework.buyflat.dto;

import com.coursework.buyflat.entity.ClientEntity;
import com.coursework.buyflat.entity.FlatEntity;
import com.coursework.buyflat.entity.OrderStatus;
import com.coursework.buyflat.entity.RealtorEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.time.LocalDate;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CreateOrderDto {
    private CreateFlatDto flat;
    private LocalDate postedDate;
    private OrderStatus status;
    private Double price;
}
