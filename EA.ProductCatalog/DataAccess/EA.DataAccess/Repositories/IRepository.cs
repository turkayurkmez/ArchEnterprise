using EA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DataAccess.Repositories
{
   public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        //void
        //TEntity 
        //int
        //bool
        //Task<int> Add(TEntity entity);

        Task<IList<TEntity>> GetEntities();
        Task<TEntity> GetEntityById(int id);

        Task Add(TEntity entity);
        Task<bool> IsEntityExist(int id);
        Task Update(Product product);

    }
}
