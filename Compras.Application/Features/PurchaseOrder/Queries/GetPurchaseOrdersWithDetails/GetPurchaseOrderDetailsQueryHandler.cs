using AutoMapper;
using Compras.Application.Contracts.Persistence;
using Compras.Application.Features.PurchaseOrder.Queries.GetAllPurchaseOrders;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersWithDetails;

public class GetPurchaseOrderDetailsQueryHandler : IRequestHandler<GetPurcharseOrderDetailsQuery, PurchaseOrderDetailsDto>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public GetPurchaseOrderDetailsQueryHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }
 
    public async Task<PurchaseOrderDetailsDto> Handle(GetPurcharseOrderDetailsQuery request, CancellationToken cancellationToken)
    {
        var purchaseOrder = await purchaseOrderRepository.GetPurchaseOrderWithDetails(request.Id);

        var purchaseOrderMappedToDto = mapper.Map<PurchaseOrderDetailsDto>(purchaseOrder);

        return purchaseOrderMappedToDto; 

    }
}
