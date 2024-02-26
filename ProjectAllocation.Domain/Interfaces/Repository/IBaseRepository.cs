using ProjectAllocation.Domain.Entities;
using System.Linq.Expressions;

namespace ProjectAllocation.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : BaseIdentity
    {
        Task<T?> GetByIdAsync(Guid id);
        Task<T?> GetByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<T?> GetIncludesByExpressionAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllIncludesByExpressionAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes);
        T Add(T entity);
        List<T> AddRange(List<T> entities);
        void Update(T entity);
        void UpdateRange(List<T> entities);
        void Delete(T entity);
    }
}
