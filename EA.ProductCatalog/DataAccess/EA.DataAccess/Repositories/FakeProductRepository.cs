using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DataAccess.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private IList<Product> products;
        public FakeProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id=1, Name ="Product X", ImageUrl="sample", Description="Desc X", Discount=0.25f, Price=150, StockCount=100},
                 new Product { Id=2, Name ="Product Y", ImageUrl="sample", Description="Desc Y", Discount=0.25f, Price=150, StockCount=100},
                  new Product { Id=3, Name ="Product Z", ImageUrl="sample", Description="Desc Z", Discount=0.25f, Price=150, StockCount=100}
            };
        }
        public async Task<IList<Product>> GetEntities()
        {
            return await Task.FromResult(products);
        }

        public Task<IEnumerable<Product>> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
