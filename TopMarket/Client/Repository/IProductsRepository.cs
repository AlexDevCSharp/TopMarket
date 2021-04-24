using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopMarket.Shared.DTOs;
using TopMarket.Shared.Entities;

namespace TopMarket.Client.Repository
{
    public interface IProductsRepository
    {
        Task<int> CreateProduct(Product product);
        Task DeleteProduct(int Id);
        Task<DetailsProductDTO> GetDetailsProductDTO(int id);
        Task<Product> GetDetailsProduct(int id);
        Task<List<ProductDiscountDto>> GetProducts(int categoryId);
        Task<ProductUpdateDTO> GetProductForUpdate(int id);
        Task<PaginatedResponse<List<Product>>> GetProductsFiltered(FilterProductsDTO filterProductsDTO);
        Task UpdateProduct(Product product);
    }
}
