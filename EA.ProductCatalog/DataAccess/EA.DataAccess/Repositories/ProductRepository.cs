using EA.DataAccess.Data;
using EA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EADbContext eaDbContext;

        public ProductRepository(EADbContext eaDbContext)
        {
            this.eaDbContext = eaDbContext;
        }

        public async Task Add(Product entity)
        {
            await eaDbContext.Products.AddAsync(entity);
            await eaDbContext.SaveChangesAsync();
        }

        public async Task<IList<Product>> GetEntities()
        {
            return await eaDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetEntityById(int id)
        {
            return await eaDbContext.Products.FindAsync(id);
        }

        public Task<bool> IsEntityExist(int id)
        {
            return eaDbContext.Products.AnyAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Product product)
        {
            eaDbContext.Products.Update(product);
            await eaDbContext.SaveChangesAsync();
        }
    }
}
