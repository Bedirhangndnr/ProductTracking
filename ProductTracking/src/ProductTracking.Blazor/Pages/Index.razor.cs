using Blazorise;
using Microsoft.AspNetCore.Components;
using ProductTracking.Dtos;
using ProductTracking.ParticleOperations;
using ProductTracking.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductTracking.Blazor.Pages;

public partial class Index
{
	[Inject] IProductAppService _productAppService { get; set; }
	[Inject] IParticleOperationAppService _particleOperationAppService { get; set; }
	public List<ProductTrackingDtos> ProductTrackingDtoes { get; set; } = new List<ProductTrackingDtos>();
	private Modal productDetailModal { get; set; }
	public ProductTrackingDtos currentProductDto { get; set; } = new ProductTrackingDtos();
	public List<ParticleOperationDto> CurrentParticleOperations { get; set; } = new List<ParticleOperationDto>();
	protected override async Task OnInitializedAsync()
	{
		ProductTrackingDtoes = await _productAppService.GetAllTrackingX();
	}
	private Task ShowModal(ProductTrackingDtos productTrackingDtos)
	{
		GetOperations(productTrackingDtos);
		currentProductDto = productTrackingDtos;
		return productDetailModal.Show();
	}
	private async void GetOperations(ProductTrackingDtos productTrackingDtos)
	{
		CurrentParticleOperations = await _particleOperationAppService.GetParticleOperationsByTrackCode(productTrackingDtos.TrackCode);
	}
	private Task HideModal()
	{
		return productDetailModal.Hide();
	}
}
