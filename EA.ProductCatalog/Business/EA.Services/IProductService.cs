using EA.Dtos.Requests;
using EA.Dtos.Responses;
using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Services
{
   public interface IProductService
    {
        Task<IList<ProductListDisplayResponse>> GetProducts();
        Task<ProductListDisplayResponse> GetProductById(int id);
        Task<int> AddProduct(AddProductRequest request);
        Task<bool> IsProductExists(int id);
        Task UpdateProduct(UpdateProductRequest request);
    }
}
