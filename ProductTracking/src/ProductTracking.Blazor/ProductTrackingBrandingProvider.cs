using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProductTracking.Blazor;

[Dependency(ReplaceServices = true)]
public class ProductTrackingBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductTracking";
}
