using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopMarket.Shared.Entities;
using TopMarket.Server.Helpers;
using System.Linq;
using TopMarket.Shared.DTOs;

namespace TopMarket.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CartController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<CartTotal>> Get()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductForCart>>(HttpContext.Session, "cart");
            var cartTotal = new CartTotal();
            cartTotal.Products = cart;
            if (cart == null)
            {
                return cartTotal;
            }
            foreach (var item in cart)
            {
                cartTotal.Total += item.ProductTotal;
            }
            return cartTotal;
        }

        [HttpGet("add/{id}")]
        public async Task<ActionResult<List<Product>>> Add(int id)
        {
            var products = await context.Products.ToListAsync();
            if (SessionHelper.GetObjectFromJson<List<ProductForCart>>(HttpContext.Session, "cart") == null)
            {
                var cart = new List<ProductForCart>();
                cart.Add(new ProductForCart() { Product = products.Where(x => x.Id == id).FirstOrDefault(), Quantity=1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                var cart = SessionHelper.GetObjectFromJson<List<ProductForCart>>(HttpContext.Session, "cart"); 
                int index = Exists(cart, id);
                if (index == -1)
                {
                    cart.Add(new ProductForCart() { Product = products.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                }
                else
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return products;
        }

        [HttpGet("remove/{typeId}/{id}")]
        public async Task<ActionResult<List<Product>>> Remove(int id, int typeId)
        {
            var products = await context.Products.ToListAsync();
            
            var cart = SessionHelper.GetObjectFromJson<List<ProductForCart>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            if (cart[index].Quantity > 1 && typeId > 0)
            {
                cart[index].Quantity--;
            }
            else
            {
                cart.RemoveAt(index);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return products;
        }

        [HttpDelete]
        public async Task<ActionResult> Clear()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ProductForCart>>(HttpContext.Session, "cart");
            cart = null;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return NoContent();
        }

        private int Exists(List<ProductForCart> cart, int id)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
