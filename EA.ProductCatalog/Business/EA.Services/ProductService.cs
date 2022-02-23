using EA.DataAccess.Repositories;
using EA.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EA.Services.Extensions;
using AutoMapper;

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
        public async Task<IList<ProductListDisplayResponse>> GetProducts()
        {
            var products = await repository.GetEntities();
            var responses = products.ConvertToDisplayDto(mapper);

            return responses;
        }
    }
}
