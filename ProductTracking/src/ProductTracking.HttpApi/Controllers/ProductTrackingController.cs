using ProductTracking.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductTracking.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductTrackingController : AbpControllerBase
{
    protected ProductTrackingController()
    {
        LocalizationResource = typeof(ProductTrackingResource);
    }
}
