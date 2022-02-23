using AutoMapper;
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
    }
}
