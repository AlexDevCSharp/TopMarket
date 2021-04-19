using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> Get()
        {
            return await context.Orders.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            var order = await context.Orders.FirstOrDefaultAsync(x => x.Id == id);
            if (order == null) { return NotFound(); }
            return order;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Order order)
        {
            context.Add(order);
            await context.SaveChangesAsync();
            return order.Id;
        }

        [HttpPost("details")]
        public async Task<ActionResult<int>> CreateOrderDetails(OrderCartDTO orderCart)
        {
            var order = new OrderDetails();
            order.OrderId = orderCart.OrderId;
            order.ProductId = orderCart.Products.Product.Id;
            order.Price = orderCart.Products.Product.Price;
            order.Quantity = orderCart.Products.Quantity;
            context.Add(order);
            await context.SaveChangesAsync();
            return orderCart.OrderId;
        }
    }
}
