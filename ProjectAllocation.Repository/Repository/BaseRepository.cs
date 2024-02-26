using Microsoft.EntityFrameworkCore;
using ProjectAllocation.Domain.Entities;
using ProjectAllocation.Domain.Interfaces.Repository;
using System.Linq.Expressions;

namespace ProjectAllocation.Repository.Repository
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseIdentity
    {
        protected readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<T?> GetByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<T?> GetIncludesByExpressionAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            return await includes.Aggregate(_dbContext.Set<T>().Where(expression).AsQueryable(), (current, include) => current.Include(include)).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().AsNoTracking().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllIncludesByExpressionAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            return await includes.Aggregate(_dbContext.Set<T>().Where(expression).AsQueryable(), (current, include) => current.Include(include)).ToListAsync();
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);

            return entity;
        }

        public List<T> AddRange(List<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);

            return entities;
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void UpdateRange(List<T> entities)
        {
            _dbContext.Set<T>().UpdateRange(entities);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

    }
}
