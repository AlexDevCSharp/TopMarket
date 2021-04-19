using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface IStateRepository
    {
        Task CreateState(State state);
        Task<State> GetState(int Id);
        Task<List<State>> GetStates();
        Task<List<State>> GetStatesForCountries(int countryId);
        Task UpdateState(State state);
        Task DeleteState(int Id);
    }
}
