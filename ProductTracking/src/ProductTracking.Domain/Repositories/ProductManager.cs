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
    public class ProductManager: DomainService
    {
        private readonly IRepository<Product,  int> _productRepository;
        private readonly IRepository<ParticleOperation,  int> _particleOperationRepository;

        public ProductManager(IRepository<Product, int> productRepository, IRepository<ParticleOperation, int> particleOperationRepository)
        {
            _productRepository = productRepository;
            _particleOperationRepository = particleOperationRepository;
        }
        // OPERASYONLARIN STATUS SAYILARINI BULMAK İÇİN METHOD:
        public async Task<List<ProductTrackingDtos>> GetAllTracking()
        {
            var returnDto= new List<ProductTrackingDtos>();
            var products= await _productRepository.GetListAsync();
            foreach (var product in products)
            {
                returnDto.Add(new ProductTrackingDtos()
                {
                    DueDate = product.DueDate,
                    ProductName= product.ProductName,
                    EndDate= product.EndDate,
                    PictureLink= product.PictureLink,
                    StartDate= product.StartDate,
                    Status= product.Status,
                    TrackCode=product.TrackCode,
                    WorkOrder=product.WorkOrder,
                    Progress=_particleOperationRepository.GetQueryableAsync().Result.Where(x=>x.OperationTrackCode== product.TrackCode).Count(x=>x.OperationStatus==SharedConstants.ProductConsts.Complete)*100/5
                });
            }
            return returnDto;
        }
        public async Task<List<ProductTrackingDtos>> GetAllTrackingX()
        {
            var returnDto = new List<ProductTrackingDtos>();
            var products = await _productRepository.GetListAsync();
            foreach (var product in products)
            {
                returnDto.Add(new ProductTrackingDtos()
                {
                    DueDate = DateTime.Now,
                    ProductName = "XXXXX",
                    EndDate = DateTime.Now,
                    PictureLink = "xx",
                    StartDate = DateTime.Now,
                    Status = "x",
                    TrackCode = "x",
                    WorkOrder = "x",
                    Progress = 20
                });
            }
            return returnDto;
        }
    }
}
