package com.coursework.buyflat.entity;

import lombok.*;

import javax.persistence.*;

@Getter
@Setter
@Entity
@Builder
@Table(name = "client")
@NoArgsConstructor
@AllArgsConstructor
public class ClientEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(name = "passport")
    private String passport;

    @OneToOne
    @JoinColumn(name = "users_id" )
    private UserEntity user;
}
