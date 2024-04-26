using Volo.Abp.Modularity;

namespace TodoApp;

public abstract class TodoAppApplicationTestBase<TStartupModule> : TodoAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
