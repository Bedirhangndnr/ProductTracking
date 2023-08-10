using System.Threading.Tasks;

namespace ProductTracking.Data;

public interface IProductTrackingDbSchemaMigrator
{
    Task MigrateAsync();
}
