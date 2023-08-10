using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductTracking.Data;

/* This is used if database provider does't define
 * IProductTrackingDbSchemaMigrator implementation.
 */
public class NullProductTrackingDbSchemaMigrator : IProductTrackingDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
