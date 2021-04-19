using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface ICategoryRepository
    {
        Task CreateCategory(Category category);
        Task<Category> GetCategory(int Id);
        Task<List<Category>> GetCategories();
        Task UpdateCategory(Category category);
        Task DeleteCategory(int Id);
    }
}
