package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;

@Getter
@Setter
@Entity
@Builder
@Table(name = "region")
@NoArgsConstructor
@AllArgsConstructor
public class RegionEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "region_name")
    private String regionName;

    @ManyToOne
    @JoinColumn(name = "city_id" )
    private CityEntity city;
}
