using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression = null, params string[] Includes);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] Includes);
        Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> expression = null, params string[] Includes);
        Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>> expression = null);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression);
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
