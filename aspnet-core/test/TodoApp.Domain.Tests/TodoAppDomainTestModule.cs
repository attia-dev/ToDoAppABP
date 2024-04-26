using Volo.Abp.Modularity;

namespace TodoApp;

[DependsOn(
    typeof(TodoAppDomainModule),
    typeof(TodoAppTestBaseModule)
)]
public class TodoAppDomainTestModule : AbpModule
{

}
