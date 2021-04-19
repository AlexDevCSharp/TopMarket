using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class SubcategoriesRepository : ISubcategoriesRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/subcategories";

        public SubcategoriesRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Subcategory>> GetSubcategories()
        {
            var response = await httpService.Get<List<Subcategory>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<List<Subcategory>> GetSubcategoriesForCountries(int countryId)
        {
            var response = await httpService.Get<List<Subcategory>>($"{url}/{countryId}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Subcategory> GetSubcategory(int Id)
        {
            var response = await httpService.Get<Subcategory>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateSubcategory(Subcategory subcategory)
        {
            var response = await httpService.Post(url, subcategory);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateSubcategory(Subcategory subcategory)
        {
            var response = await httpService.Put(url, subcategory);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSubcategory(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
