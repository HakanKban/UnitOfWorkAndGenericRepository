using System.Linq.Expressions;

namespace UnitOfWorkAndGenericRepository.Repository
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int entityId);
        Task<IReadOnlyList<T>> GetAllAsync();

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);
        Task SaveAsync();
        Task DeleteAsync(T entity);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

    }
}
