using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersByItsAvailability;

public class GetPurchaseOrdersFilteredByItsAvailabilityQueryHandler : IRequestHandler<GetPurchaseOrdersFilteredByItsAvailabilityQuery,
    List<PurchasedOrderFilteredByAvailabilityDto>>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public GetPurchaseOrdersFilteredByItsAvailabilityQueryHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<List<PurchasedOrderFilteredByAvailabilityDto>> Handle(GetPurchaseOrdersFilteredByItsAvailabilityQuery request,
        CancellationToken cancellationToken)
    {
        var purchaseOrders = await purchaseOrderRepository.GetPurchaseOrdersByItsAvailability(request.IsAvailable);

        var purchaseOrdersMappedToDto = mapper.Map<List<PurchasedOrderFilteredByAvailabilityDto>>(purchaseOrders);

        return purchaseOrdersMappedToDto; 
    }
}
