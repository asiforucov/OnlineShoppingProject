using Core.Interfaces;
using Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class
    {

        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> expression = null, params string[] Includes)
        {
            var query = GetQuery(Includes);

            return expression is null
                ? await query.FirstOrDefaultAsync()
                : await query.Where(expression).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params string[] Includes)
        {
            var query = GetQuery(Includes);

            return expression is null
                ? await query.ToListAsync()
                : await query.Where(expression).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> expression = null, params string[] Includes)
        {
            var query = GetQuery(Includes);

            return expression is null
                ? await query.Skip((page - 1) * size).Take(size).ToListAsync()
                : await query.Where(expression).Skip((page - 1) * size).Take(size).ToListAsync();
        }

        public async Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression is null
                ? await _context.Set<TEntity>().CountAsync()
                : await _context.Set<TEntity>().Where(expression).CountAsync();
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }


        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }


        private IQueryable<TEntity> GetQuery(params string[] Includes)
        {

            var query = _context.Set<TEntity>().AsQueryable();

            if (Includes != null)
            {
                foreach (var item in Includes)
                {
                    query = query.Include(item);
                }
            }

            return query;
        }
    }
}
