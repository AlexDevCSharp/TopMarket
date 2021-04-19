using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface ISubcategoriesRepository
    {
        Task CreateSubcategory(Subcategory subcategory);
        Task<Subcategory> GetSubcategory(int Id);
        Task<List<Subcategory>> GetSubcategories();
        Task<List<Subcategory>> GetSubcategoriesForCountries(int countryId);
        Task UpdateSubcategory(Subcategory subcategory);
        Task DeleteSubcategory(int Id);
    }
}
