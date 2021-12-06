package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;

@Getter
@Setter
@Entity
@Builder
@Table(name = "street")
@NoArgsConstructor
@AllArgsConstructor
public class StreetEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "street_name")
    private String streetName;

    @ManyToOne
    @JoinColumn(name = "region_id" )
    private RegionEntity region;
}
