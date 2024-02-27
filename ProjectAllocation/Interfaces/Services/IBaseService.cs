namespace ProjectAllocation.API.Interfaces.Service
{
    public interface IBaseService<T>
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
