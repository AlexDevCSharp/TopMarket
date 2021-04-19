using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class OrderRepository: IOrderRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/order";

        public OrderRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Order>> GetOrders()
        {
            var response = await httpService.Get<List<Order>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Order> GetOrder(int Id)
        {
            var response = await httpService.Get<Order>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<int> CreateOrder(Order order)
        {
            var response = await httpService.Post<Order, int>(url, order);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task CreateOrderDetails(OrderCartDTO orderCart)
        {
            var response = await httpService.Post($"{url}/details", orderCart);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateOrder(Order order)
        {
            var response = await httpService.Put(url, order);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteOrder(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
