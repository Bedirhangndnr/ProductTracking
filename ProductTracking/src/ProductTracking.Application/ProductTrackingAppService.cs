using System;
using System.Collections.Generic;
using System.Text;
using ProductTracking.Localization;
using Volo.Abp.Application.Services;

namespace ProductTracking;

/* Inherit your application services from this class.
 */
public abstract class ProductTrackingAppService : ApplicationService
{
    protected ProductTrackingAppService()
    {
        LocalizationResource = typeof(ProductTrackingResource);
    }
}
