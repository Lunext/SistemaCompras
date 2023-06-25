using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetAllPurchaseOrders
{
    public class GetPurchaseOrdersQueryHandler : IRequestHandler<GetPurchaseOrdersQuery, List<PurchaseOrderDto>>
    {
        private readonly IMapper mapper;
        private readonly IPurchaseOrderRepository purchaseOrderRepository;


        public GetPurchaseOrdersQueryHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
        {
            this.mapper = mapper;
            this.purchaseOrderRepository = purchaseOrderRepository;
        }


        public async Task<List<PurchaseOrderDto>> Handle(GetPurchaseOrdersQuery request, CancellationToken cancellationToken)
        {
            var purchaseOrders = await purchaseOrderRepository.GetPurchaseOrdersWithDetails();
            var purchaseOrdersMappedToDto = mapper.Map<List<PurchaseOrderDto>>(purchaseOrders);

            return purchaseOrdersMappedToDto;
        }

    }
}
