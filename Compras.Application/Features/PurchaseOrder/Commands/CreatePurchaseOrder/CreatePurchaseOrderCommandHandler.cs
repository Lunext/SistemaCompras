using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Commands.CreatePurchaseOrder;

public class CreatePurchaseOrderCommandHandler : IRequestHandler<CreatePurchaseOrderCommand, int>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public CreatePurchaseOrderCommandHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<int> Handle(CreatePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        var purchaseOrderToCreate = mapper.Map<Domain.Domains.PurchaseOrder>(request);
        await purchaseOrderRepository.CreateAsync(purchaseOrderToCreate);

        return purchaseOrderToCreate.Id; 
    }

}
