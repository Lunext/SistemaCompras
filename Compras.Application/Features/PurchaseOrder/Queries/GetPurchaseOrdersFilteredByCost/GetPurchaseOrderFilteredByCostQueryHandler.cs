using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByCost;

public class GetPurchaseOrderFilteredByCostQueryHandler : IRequestHandler<GetPurchaseOrdersFilteredByCostQuery, List<PurchaseOrderByCostDto>>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public GetPurchaseOrderFilteredByCostQueryHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<List<PurchaseOrderByCostDto>> Handle(GetPurchaseOrdersFilteredByCostQuery request, CancellationToken cancellationToken)
    {
        var purchaseOrders = await purchaseOrderRepository.GetPurchaseOrdersByUnitCost(request.firstCost, request.lastCost); 

        var purchaseOrdersMappedToDto= mapper.Map<List<PurchaseOrderByCostDto>>(purchaseOrders);

        return purchaseOrdersMappedToDto;
    }
}

