package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;

@Getter
@Setter
@Entity
@Builder
@Table(name = "realtor")
@NoArgsConstructor
@AllArgsConstructor
public class RealtorEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "percent")
    private Double percent;

    @OneToOne
    @JoinColumn(name = "users_id" )
    private UserEntity user;
}
