using Volo.Abp.Settings;

namespace ProductTracking.Settings;

public class ProductTrackingSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductTrackingSettings.MySetting1));
    }
}
