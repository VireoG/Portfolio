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
@AllArgsConstructor
@NoArgsConstructor
public class OrderDto {
    private RealtorEntity realtor;
    private FlatEntity flat;
    private ClientEntity client;
    private LocalDate postedDate;
    private OrderStatus status;
    private Double price;
}
