using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface ICountryRepository
    {
        Task CreateCountry(Country country);
        Task<Country> GetCountry(int Id);
        Task<List<Country>> GetCountries();
        Task UpdateCountry(Country country);
        Task DeleteCountry(int Id);
    }
}
