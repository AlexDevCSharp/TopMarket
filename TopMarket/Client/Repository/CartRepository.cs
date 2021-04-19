using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class CartRepository: ICartRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/cart";

        public CartRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<CartTotal> GetCart()
        {
            var response = await httpService.Get<CartTotal>($"{url}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task Add(int id)
        {
            var response = await httpService.Get<List<Product>>($"{url}/add/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task Remove(int id, int typeId)
        {
            var response = await httpService.Get<List<Product>>($"{url}/remove/{typeId}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task Clear()
        {
            var response = await httpService.Delete($"{url}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

    }
}
