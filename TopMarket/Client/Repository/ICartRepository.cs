using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.DTOs;

namespace TopMarket.Client.Repository
{
    public interface ICartRepository
    {
        Task<CartTotal> GetCart();
        //Task<List<Category>> GetCategories();
        Task Clear();
        Task Add(int id);
        Task Remove(int id, int typeId);
        //Task DeleteCategory(int Id);
    }
}
