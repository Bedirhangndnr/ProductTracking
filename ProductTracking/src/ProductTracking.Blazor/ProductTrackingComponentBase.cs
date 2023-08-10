using ProductTracking.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ProductTracking.Blazor;

public abstract class ProductTrackingComponentBase : AbpComponentBase
{
    protected ProductTrackingComponentBase()
    {
        LocalizationResource = typeof(ProductTrackingResource);
    }
}
