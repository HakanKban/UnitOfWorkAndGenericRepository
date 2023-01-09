using Module = Autofac.Module;
using Autofac;
using UnitOfWorkAndGenericRepository.UOW;
using UnitOfWorkAndGenericRepository.Repository;
using UnitOfWorkAndGenericRepository.Entity;

namespace UnitOfWorkAndGenericRepository
{
    public class RepoServiceModule : Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<AsyncRepository<Category>>().As<IAsyncRepository<Category>>();
            builder.RegisterType<AsyncRepository<Product>>().As<IAsyncRepository<Product>>();

          
        }
       
    }
}
