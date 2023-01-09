using UnitOfWorkAndGenericRepository.Entity;
using UnitOfWorkAndGenericRepository.Repository;

namespace UnitOfWorkAndGenericRepository.UOW
{
    public interface IUnitOfWork
    {
        IAsyncRepository<Product> ProductRepository { get; }
        IAsyncRepository<Category> CategoryRepository { get; }
    }
}
