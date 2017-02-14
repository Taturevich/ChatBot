using Ninject.Extensions.Conventions;
using Ninject.Modules;

namespace BusinessLogic.Infrastructure
{
    public class BusinessLogicModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(Repository<>));
            Bind(typeof(IEntityServiceBase<>)).To(typeof(EntityServiceBase<>));
            Bind<BlDbContext>().ToSelf();
            Bind<EventLogInterceptor>().ToSelf();
            Bind<ITransactionalInterceptor>().To<TransactionalInterceptor>();
            Kernel.Bind(x => x.FromThisAssembly()
                .IncludingNonePublicTypes()
                .SelectAllClasses()
                .InheritedFrom(typeof(EntityServiceBase<>))
                .BindDefaultInterfaces());
        }
    }
}
