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
    }
}
