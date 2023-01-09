using UnitOfWorkAndGenericRepository.Context;
using UnitOfWorkAndGenericRepository.Entity;
using UnitOfWorkAndGenericRepository.Repository;

namespace UnitOfWorkAndGenericRepository.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext _myContext;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(MyContext myContext, IServiceProvider serviceProvider)
        {
            _myContext = myContext;
            _serviceProvider = serviceProvider;
         
        }

        private IAsyncRepository<Product> _productRepository;
        private IAsyncRepository<Category> _categoryRepository;

        public IAsyncRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == default(IAsyncRepository<Product>))
                    _productRepository = _serviceProvider.GetRequiredService<IAsyncRepository<Product>>();

                return _productRepository;
            }
        }       
        
        public IAsyncRepository<Category> CategoryRepository
        {
            get
            {
                if (_categoryRepository == default(IAsyncRepository<Category>))
                    _categoryRepository = _serviceProvider.GetRequiredService<IAsyncRepository<Category>>();

                return _categoryRepository;
            }
        }

    }
}
