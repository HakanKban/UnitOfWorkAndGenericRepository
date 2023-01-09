using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnitOfWorkAndGenericRepository.Context;

namespace UnitOfWorkAndGenericRepository.Repository
{
    public class AsyncRepository<T> : IAsyncRepository<T> where T : class
    {
        private readonly MyContext _myContext;

        public AsyncRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _myContext.Set<T>().AddAsync(entity);
            _myContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
             _myContext.Set<T>().Remove(entity);
            await Task.CompletedTask;
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
           return await _myContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await _myContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _myContext.Entry(entity).State = EntityState.Modified;
            await Task.CompletedTask;
        }
    }
}
