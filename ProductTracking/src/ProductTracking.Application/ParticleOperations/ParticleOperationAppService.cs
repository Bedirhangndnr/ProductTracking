using ProductTracking.Dtos;
using ProductTracking.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductTracking.ParticleOperations
{
    public class ParticleOperationAppService : ApplicationService, IParticleOperationAppService
    {
        private ParticleOperationManager _particleOperationManager;

        public ParticleOperationAppService(ParticleOperationManager particleOperationManager)
        {
            _particleOperationManager = particleOperationManager;
        }

        public async Task<List<ParticleOperationDto>> GetParticleOperationsByTrackCode(string trackCode)
        {
            var particleOperation= await _particleOperationManager.GetParticleOperationsByTrackCode(trackCode);
            return ObjectMapper.Map<List<ParticleOperation>, List<ParticleOperationDto>>(particleOperation);
        }
    }
}
