package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;

@Getter
@Setter
@Entity
@Builder
@Table(name = "bathroom")
@NoArgsConstructor
@AllArgsConstructor
public class BathroomEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "bathroom_type")
    private String bathroomName;
}
