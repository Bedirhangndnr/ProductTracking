using ProductTracking.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductTracking.ParticleOperations
{
    public interface IParticleOperationAppService: IApplicationService
    {
        Task<List<ParticleOperationDto>> GetParticleOperationsByTrackCode(string trackCode);
    }
}
