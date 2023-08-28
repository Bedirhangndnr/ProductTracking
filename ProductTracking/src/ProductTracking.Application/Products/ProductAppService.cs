using ProductTracking.Dtos;
using ProductTracking.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductTracking.Products
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private ProductManager _productManager;
        public ProductAppService(ProductManager productManager)
        {
            _productManager = productManager;
        }

        public Task<List<ProductTrackingDtos>> GetAllTracking()
        {
            return _productManager.GetAllTracking();
        }
        public Task<List<ProductTrackingDtos>> GetAllTrackingX()
        {
            return _productManager.GetAllTrackingX();
        }

    }
}
