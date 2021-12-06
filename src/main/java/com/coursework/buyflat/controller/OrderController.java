package com.coursework.buyflat.controller;

import com.coursework.buyflat.dto.CreateOrderDto;
import com.coursework.buyflat.dto.OrderDto;
import com.coursework.buyflat.service.OrderService;
import com.coursework.buyflat.service.RoomService;
import com.coursework.buyflat.service.StreetService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/order")
@RequiredArgsConstructor
public class OrderController {
    private final OrderService orderService;

    @PostMapping("/create")
    public void createOrder(@RequestBody CreateOrderDto orderDto) {
        orderService.createOrder(orderDto);
    }

    @PostMapping("/{id}")
    public void chooseOrder(@PathVariable(value = "id") Long id) {
        orderService.chooseOrder(id);
    }

    @GetMapping("/{id}")
    public OrderDto getOrder(@PathVariable(value = "id") Long id) {
        return orderService.getOrder(id);
    }

    @GetMapping("/all")
    public List<OrderDto> getAll() {
        return orderService.getAll();
    }

    @GetMapping("/users")
    public List<OrderDto> getUsersOrders() {
        return orderService.getUserOrders();
    }
}
