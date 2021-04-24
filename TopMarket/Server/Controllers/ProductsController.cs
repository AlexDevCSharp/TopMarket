using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Server.Helpers;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFileStorageService fileStorageService;
        private readonly IMapper mapper;
        private string containerName = "products";

        public ProductsController(ApplicationDbContext context,
            IFileStorageService fileStorageService
            , IMapper mapper
            )
        {
            this.context = context;
            this.fileStorageService = fileStorageService;
            this.mapper = mapper;
        }

        [HttpGet("category/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<List<ProductDiscountDto>>> GetProducts(int id)
        {
            var products = new List<Product>();
            if (id == 0)
            {
                products = await context.Products.ToListAsync();
            }
            else
            {
                products = await (from p in context.Products
                                  join s in context.Subcategories on p.SubcatId equals s.Id
                                  join c in context.Categories on s.CategoryId equals c.Id
                                  where s.CategoryId == id
                                  select p).ToListAsync();
            }
            var discounts = await context.Discounts.ToListAsync();
            List<ProductDiscountDto> productsDTO = new List<ProductDiscountDto>();
            foreach (var product in products)
            {
                var discount = discounts.FirstOrDefault(x => x.ProductId == product.Id);
                ProductDiscountDto productDiscountDto = new ProductDiscountDto();
                productDiscountDto.Product = product;
                if (discount != null)
                {
                    productDiscountDto.LastPrice = (product.Price * (100 - 50) / 100);
                }
                else { productDiscountDto.LastPrice = product.Price; }

                productsDTO.Add(productDiscountDto);
            }
            return productsDTO;
        }

        [HttpGet("details/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Product>> GetDetailsProduct(int id)
        {
            var product = await context.Products.Where(x => x.Id == id)
                //.Include(x => x.ProductsCategories)
                //.ThenInclude(x => x.Category)
                .FirstOrDefaultAsync();

            if (product == null) { return NotFound(); }

            //model.Categories = product.ProductsCategories.Select(x => x.Category).ToList();

            return product;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<DetailsProductDTO>> Get(int id)
        {
            var product = await context.Products.Where(x => x.Id == id)
                //.Include(x => x.ProductsCategories)
                //.ThenInclude(x => x.Category)
                .FirstOrDefaultAsync();

            if (product == null) { return NotFound(); }

            var model = new DetailsProductDTO();
            model.Product = product;
            model.Categories = null;
            //model.Categories = product.ProductsCategories.Select(x => x.Category).ToList();

            return model;
        }

        [HttpPost("filter")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Product>>> Filter(FilterProductsDTO filterProductsDTO)
        {
            var productsQueryable = context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterProductsDTO.Title))
            {
                productsQueryable = productsQueryable
                    .Where(x => x.Title.Contains(filterProductsDTO.Title));
            }

            //if (filterProductsDTO.InTheaters)
            //{
            //    productsQueryable = productsQueryable.Where(x => x.InTheaters);
            //}

            //if (filterProductsDTO.UpcomingReleases)
            //{
            //    var today = DateTime.Today;
            //    productsQueryable = productsQueryable.Where(x => x.ReleaseDate > today);
            //}

            if (filterProductsDTO.CategoryId != 0)
            {
                //productsQueryable = productsQueryable
                //    .Where(x => x.ProductsCategories.Select(y => y.CategoryId)
                //    .Contains(filterProductsDTO.CategoryId));
            }

            await HttpContext.InsertPaginationParametersInResponse(productsQueryable,
                filterProductsDTO.RecordsPerPage);

            var products = await productsQueryable.Paginate(filterProductsDTO.Pagination).ToListAsync();

            return products;
        }



        [HttpGet("update/{id}")]
        public async Task<ActionResult<ProductUpdateDTO>> PutGet(int id)
        {
            var productActionResult = await Get(id);
            if (productActionResult.Result is NotFoundResult) { return NotFound(); }

            var productDetailDTO = productActionResult.Value;
            var selectedCategoriesIds = productDetailDTO.Categories.Select(x => x.Id).ToList();
            var notSelectedCategories = await context.Categories
                .Where(x => !selectedCategoriesIds.Contains(x.Id))
                .ToListAsync();

            var model = new ProductUpdateDTO();
            model.Product = productDetailDTO.Product;
            model.SelectedCategories = productDetailDTO.Categories;
            model.NotSelectedCategories = notSelectedCategories;
            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Product product)
        {
            if (!string.IsNullOrWhiteSpace(product.Poster))
            {
                var poster = Convert.FromBase64String(product.Poster);
                product.Poster = await fileStorageService.SaveFile(poster, "jpg", containerName);
            }

            context.Add(product);
            await context.SaveChangesAsync();
            return product.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Product product)
        {
            var productDB = await context.Products.FirstOrDefaultAsync(x => x.Id == product.Id);

            if (productDB == null) { return NotFound(); }

            productDB = mapper.Map(product, productDB);

            if (!string.IsNullOrWhiteSpace(product.Poster))
            {
                var productPoster = Convert.FromBase64String(product.Poster);
                productDB.Poster = await fileStorageService.EditFile(productPoster,
                    "jpg", containerName, productDB.Poster);
            }

            //await context.Database.ExecuteSqlInterpolatedAsync($"delete from ProductsCategories where ProductId = {product.Id}");

            //productDB.ProductsCategories = product.ProductsCategories;

            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            context.Remove(product);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
