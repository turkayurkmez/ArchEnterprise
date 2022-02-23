
using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public Task<IEnumerable<Product>> SearchProductByName(string name);
    }
}
