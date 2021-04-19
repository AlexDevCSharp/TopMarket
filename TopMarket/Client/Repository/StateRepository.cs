using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class StateRepository : IStateRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/states";

        public StateRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<State>> GetStates()
        {
            var response = await httpService.Get<List<State>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<List<State>> GetStatesForCountries(int countryId)
        {
            var response = await httpService.Get<List<State>>($"{url}/{countryId}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<State> GetState(int Id)
        {
            var response = await httpService.Get<State>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task CreateState(State state)
        {
            var response = await httpService.Post(url, state);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateState(State state)
        {
            var response = await httpService.Put(url, state);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteState(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
