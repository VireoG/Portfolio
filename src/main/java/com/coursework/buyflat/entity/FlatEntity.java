package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;
import java.time.LocalDate;

@Getter
@Setter
@Entity
@Builder
@Table(name = "flat")
@NoArgsConstructor
@AllArgsConstructor
public class FlatEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    @JoinColumn(name = "street_id" )
    private StreetEntity street;

    @ManyToOne
    @JoinColumn(name = "bathroom_id" )
    private BathroomEntity bathroom;

    @ManyToOne
    @JoinColumn(name = "room_id" )
    private RoomEntity room;

    @Column(name = "number_flat")
    private String numberFlat;

    @Column(name = "area")
    private Double area;
}
