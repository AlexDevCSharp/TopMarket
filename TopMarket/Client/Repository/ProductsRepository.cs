using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Client.Helpers;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/products";

        public ProductsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<ProductDiscountDto>> GetProducts()
        {
            var response = await httpService.Get<List<ProductDiscountDto>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Product> GetDetailsProduct(int id)
        {
            var response = await httpService.Get<Product>($"{url}/details/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Product>> GetProductsByCategory(int id)
        {
            var response = await httpService.Get<List<Product>>($"{url}/category/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<DetailsProductDTO> GetDetailsProductDTO(int id)
        {
            var response = await httpService.Get<DetailsProductDTO>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<ProductUpdateDTO> GetProductForUpdate(int id)
        {
            var response = await httpService.Get<ProductUpdateDTO>($"{url}/update/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        //public async Task<DetailsProductDTO> GetDetailsProductDTO(int id)
        //{
        //    return await httpService.GetHelper<DetailsProductDTO>($"{url}/{id}");
        //}

        public async Task<PaginatedResponse<List<Product>>> GetProductsFiltered(FilterProductsDTO filterProductsDTO)
        {
            var responseHTTP = await httpService.Post<FilterProductsDTO, List<Product>>($"{url}/filter", filterProductsDTO);
            var totalAmountPages = int.Parse(responseHTTP.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<List<Product>>()
            {
                Response = responseHTTP.Response,
                TotalAmountPages = totalAmountPages
            };

            return paginatedResponse;
        }

        public async Task<int> CreateProduct(Product product)
        {
            var response = await httpService.Post<Product, int>(url, product);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task UpdateProduct(Product poduct)
        {
            var response = await httpService.Put(url, poduct);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteProduct(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
