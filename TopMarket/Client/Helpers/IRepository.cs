using TopMarket.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopMarket.Client.Helpers
{
    public interface IRepository
    {
        List<Product> GetProducts();
    }
}
