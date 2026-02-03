using FinApp.Domain.Interfaces.Repositories;
using FinApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TKey>
(DataContext dataContext) : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        //private readonly DataContext _dataContext;

        //protected BaseRepository(DataContext dataContext)
        //{
        //    _dataContext = dataContext;
        //}
        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetByIdAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
