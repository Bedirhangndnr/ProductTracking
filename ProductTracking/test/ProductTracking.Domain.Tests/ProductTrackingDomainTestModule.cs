using ProductTracking.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductTracking;

[DependsOn(
    typeof(ProductTrackingEntityFrameworkCoreTestModule)
    )]
public class ProductTrackingDomainTestModule : AbpModule
{

}
