package com.coursework.buyflat.service;

import com.coursework.buyflat.dto.CreateOrderDto;
import com.coursework.buyflat.dto.OrderDto;
import com.coursework.buyflat.entity.*;
import com.coursework.buyflat.mapper.OrderMapper;
import com.coursework.buyflat.repo.ClientRepo;
import com.coursework.buyflat.repo.OrderRepo;
import com.coursework.buyflat.repo.RealtorRepo;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Service;

import java.util.List;


@Service
@RequiredArgsConstructor
public class OrderService {
    private final RealtorRepo realtorRepo;
    private final OrderRepo orderRepo;
    private final ClientRepo clientRepo;
    private final OrderMapper orderMapper;
    private final FlatService flatService;
    private final AuthenticationService authenticationService;

    public void createOrder(CreateOrderDto orderDto) {
        UserEntity user = authenticationService.getUser();
        RealtorEntity realtor = realtorRepo.findByUser(user).orElseThrow(() -> new RuntimeException(""));
        OrderEntity order = OrderEntity.builder()
                .postedDate(orderDto.getPostedDate())
                .flat(flatService.createFlat(orderDto.getFlat()))
                .price(orderDto.getPrice())
                .status(orderDto.getStatus())
                .realtor(realtor)
                .build();
        orderRepo.save(order);
    }

    public void chooseOrder(Long id) {
        UserEntity user = authenticationService.getUser();
        ClientEntity client = clientRepo.findByUser(user).orElseThrow(() -> new RuntimeException(""));
        OrderEntity order = orderRepo.findById(id).orElseThrow(() -> new RuntimeException());
        order.setClient(client);
        order.setStatus(OrderStatus.CLOSED);
        orderRepo.save(order);
    }

    public List<OrderDto> getAll() {
        List<OrderEntity> orders = orderRepo.findAll();
        return orderMapper.ordersToDtos(orders);
    }

    public OrderDto getOrder(Long id) {
        OrderEntity order = orderRepo.findById(id).orElseThrow(() -> new RuntimeException());
        return orderMapper.orderToDto(order);
    }

    public List<OrderDto> getUserOrders(){
        UserEntity user = authenticationService.getUser();
        if(user.getType().equals(UserType.REALTOR)) {
            RealtorEntity realtor = realtorRepo.findByUser(user).orElseThrow(() -> new RuntimeException(""));
            return orderMapper.ordersToDtos(orderRepo.findAllByRealtor(realtor));
        } else {
            ClientEntity client = clientRepo.findByUser(user).orElseThrow(() -> new RuntimeException(""));
            return orderMapper.ordersToDtos(orderRepo.findAllByClient(client));
        }
    }
}
