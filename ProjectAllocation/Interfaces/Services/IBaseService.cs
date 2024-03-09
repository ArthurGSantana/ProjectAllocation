namespace ProjectAllocation.API.Interfaces.Service
{
    public interface IBaseService<T>
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        T Add(T entity);
        Task<bool> Update(T entity);
        void Delete(T entity);
    }
}
