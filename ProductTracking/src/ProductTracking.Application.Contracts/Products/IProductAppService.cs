using ProductTracking.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductTracking.Products
{
	public interface IProductAppService : IApplicationService
	{
		Task<List<ProductTrackingDtos>> GetAllTracking();
		Task<List<ProductTrackingDtos>> GetAllTrackingX();

	}
}
