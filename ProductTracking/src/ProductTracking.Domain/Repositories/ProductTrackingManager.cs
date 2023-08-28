using ProductTracking.Dtos;
using ProductTracking.ParticleOperations;
using ProductTracking.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace ProductTracking.Repositories
{
    public class ParticleOperationManager: DomainService
    {
        private readonly IRepository<ParticleOperation,  int> _particleOperationRepository;

        public ParticleOperationManager( IRepository<ParticleOperation, int> particleOperationRepository)
        {
            _particleOperationRepository = particleOperationRepository;
        }

        public async Task<List<ParticleOperation>> GetParticleOperationsByTrackCode(string trackCode)
        {
            return await _particleOperationRepository.GetListAsync(x=>x.OperationCode== trackCode);
        }
    }
}
