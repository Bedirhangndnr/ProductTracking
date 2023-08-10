using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductTracking.Data;
using Volo.Abp.DependencyInjection;

namespace ProductTracking.EntityFrameworkCore;

public class EntityFrameworkCoreProductTrackingDbSchemaMigrator
    : IProductTrackingDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductTrackingDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ProductTrackingDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductTrackingDbContext>()
            .Database
            .MigrateAsync();
    }
}
