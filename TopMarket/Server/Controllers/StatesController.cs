using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;

namespace TopMarket.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public StatesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{countryId}")]
        public async Task<ActionResult<List<State>>> Get(int countryId)
        {
            return await context.States.Where(x => x.CountryId == countryId)
                .OrderBy(x => x.Name).ToListAsync();
        }
    }
}
