using Volo.Abp.Modularity;

namespace TodoApp;

/* Inherit from this class for your domain layer tests. */
public abstract class TodoAppDomainTestBase<TStartupModule> : TodoAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
