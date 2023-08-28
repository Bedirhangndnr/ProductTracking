using AutoMapper;
using ProductTracking.Dtos;
using ProductTracking.ParticleOperations;

namespace ProductTracking;

public class ProductTrackingApplicationAutoMapperProfile : Profile
{
    public ProductTrackingApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<ParticleOperation, ParticleOperationDto>();
    }
}
