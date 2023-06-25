
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByDate;

public class GetPurchaseOrdersFilteredByDateQueryHandler
    : IRequestHandler<GetPurchaseOrdersFilteredByDateQuery, List<PurchaseOrdersFilteredByDateDto>>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public GetPurchaseOrdersFilteredByDateQueryHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }


    public async Task<List<PurchaseOrdersFilteredByDateDto>> Handle(GetPurchaseOrdersFilteredByDateQuery request, CancellationToken cancellationToken)
    {
        var purchaseOrders = await purchaseOrderRepository.GetPurchaseOrdersFilteredByDate(request.firtDate, request.lastDate);

        var purchaseOrdersMappedToDto = mapper.Map<List<PurchaseOrdersFilteredByDateDto>>(purchaseOrders);

        return purchaseOrdersMappedToDto;
    }
}
