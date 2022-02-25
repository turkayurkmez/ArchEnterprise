using EA.DataAccess.Repositories;
using EA.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EA.Services.Extensions;
using AutoMapper;
using EA.Entities;
using EA.Dtos.Requests;

namespace EA.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository repository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<int> AddProduct(AddProductRequest request)
        {
            Product product = request.ConvertToEntity(mapper);
            await repository.Add(product);
            return product.Id;
        }

        public async Task<ProductListDisplayResponse> GetProductById(int id)
        {
            Product product = await repository.GetEntityById(id);
            return product.ConvertToDisplayDto(mapper);
        }

        public async Task<IList<ProductListDisplayResponse>> GetProducts()
        {
            var products = await repository.GetEntities();
            var responses = products.ConvertToDisplayDto(mapper);

            return responses;
        }

        public async Task<bool> IsProductExists(int id)
        {
            return await repository.IsEntityExist(id);
        }

        public async Task UpdateProduct(UpdateProductRequest request)
        {
            Product product = request.ConvertToEntity(mapper);
            await repository.Update(product, request.RowVersion);

        }

       
    }
}
