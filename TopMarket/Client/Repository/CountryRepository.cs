using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class CountryRepository: ICountryRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/countries";

        public CountryRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Country>> GetCountries()
        {
            var response = await httpService.Get<List<Country>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Country> GetCountry(int Id)
        {
            var response = await httpService.Get<Country>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateCountry(Country country)
        {
            var response = await httpService.Post(url, country);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateCountry(Country country)
        {
            var response = await httpService.Put(url, country);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteCountry(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
