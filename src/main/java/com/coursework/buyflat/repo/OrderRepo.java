package com.coursework.buyflat.repo;

import com.coursework.buyflat.entity.ClientEntity;
import com.coursework.buyflat.entity.OrderEntity;
import com.coursework.buyflat.entity.RealtorEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface OrderRepo extends JpaRepository<OrderEntity, Long> {
    List<OrderEntity> findAllByRealtor(RealtorEntity realtor);
    List<OrderEntity> findAllByClient(ClientEntity client);
}
