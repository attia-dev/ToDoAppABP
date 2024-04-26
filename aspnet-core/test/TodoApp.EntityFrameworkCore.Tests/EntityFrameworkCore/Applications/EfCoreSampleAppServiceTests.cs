using TodoApp.Samples;
using Xunit;

namespace TodoApp.EntityFrameworkCore.Applications;

[Collection(TodoAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TodoAppEntityFrameworkCoreTestModule>
{

}
