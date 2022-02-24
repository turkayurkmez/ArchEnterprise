using AutoMapper;
using EA.Dtos.Requests;
using EA.Dtos.Responses;
using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.Services.Extensions
{
  public static  class Converters
    {
        public static List<ProductListDisplayResponse> ConvertToDisplayDto(this IList<Product> products, IMapper mapper)
        {
            return mapper.Map<List<ProductListDisplayResponse>>(products);
        }

        public static ProductListDisplayResponse ConvertToDisplayDto(this Product product, IMapper mapper)
        {
            return mapper.Map<ProductListDisplayResponse>(product);
        }

        public static Product ConvertToEntity(this AddProductRequest request, IMapper mapper)
        {
            return mapper.Map<Product>(request);
        }

        public static Product ConvertToEntity(this UpdateProductRequest request, IMapper mapper)
        {
            return mapper.Map<Product>(request);
        }
    }
}
