using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IList<Product>> GetEntities()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
