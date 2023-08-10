using ProductTracking.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProductTracking.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductTrackingEntityFrameworkCoreModule),
    typeof(ProductTrackingApplicationContractsModule)
    )]
public class ProductTrackingDbMigratorModule : AbpModule
{
}
