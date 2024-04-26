using TodoApp.Samples;
using Xunit;

namespace TodoApp.EntityFrameworkCore.Domains;

[Collection(TodoAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TodoAppEntityFrameworkCoreTestModule>
{

}
