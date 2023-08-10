using Volo.Abp.Modularity;

namespace ProductTracking;

[DependsOn(
    typeof(ProductTrackingApplicationModule),
    typeof(ProductTrackingDomainTestModule)
    )]
public class ProductTrackingApplicationTestModule : AbpModule
{

}
