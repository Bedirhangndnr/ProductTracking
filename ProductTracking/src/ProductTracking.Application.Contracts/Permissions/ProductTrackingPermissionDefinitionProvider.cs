using ProductTracking.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProductTracking.Permissions;

public class ProductTrackingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductTrackingPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductTrackingPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductTrackingResource>(name);
    }
}
