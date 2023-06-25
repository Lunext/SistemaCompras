

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Commands.UpdatePurchaseOrder;

public class UpdatePurchaseOrderCommandHandler : IRequestHandler<UpdatePurchaseOrderCommand, Unit>
{
    private readonly IMapper mapper;
    private readonly IPurchaseOrderRepository purchaseOrderRepository;

    public UpdatePurchaseOrderCommandHandler(IMapper mapper, IPurchaseOrderRepository purchaseOrderRepository)
    {
        this.mapper = mapper;
        this.purchaseOrderRepository = purchaseOrderRepository;
    }



    public async Task<Unit> Handle(UpdatePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        var purchaseOrderToUpdate = mapper.Map<Domain.Domains.PurchaseOrder>(request); 
        
        await purchaseOrderRepository.UpdateAsync(purchaseOrderToUpdate);

        return Unit.Value;  
    }
}
