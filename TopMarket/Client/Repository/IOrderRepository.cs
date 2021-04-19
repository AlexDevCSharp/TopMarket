using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface IOrderRepository
    {
        Task<int> CreateOrder(Order order);
        Task CreateOrderDetails(OrderCartDTO orderCart);
        Task<Order> GetOrder(int Id);
        Task<List<Order>> GetOrders();
        Task UpdateOrder(Order order);
        Task DeleteOrder(int Id);
    }
}
