package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;
import java.time.LocalDate;

@Getter
@Setter
@Entity
@Builder
@Table(name = "orders")
@NoArgsConstructor
@AllArgsConstructor
public class OrderEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    @JoinColumn(name = "realtor_id" )
    private RealtorEntity realtor;

    @ManyToOne
    @JoinColumn(name = "flat_id" )
    private FlatEntity flat;

    @ManyToOne
    @JoinColumn(name = "client_id" )
    private ClientEntity client;

    @Column(name = "posted_date")
    private LocalDate postedDate;

    @Enumerated(EnumType.STRING)
    @Column(name = "status")
    private OrderStatus status;

    @Column(name = "price")
    private Double price;
}
