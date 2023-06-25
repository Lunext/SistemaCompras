using Compras.Application.Contracts.Persistence;
using Compras.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.PurchaseOrder.Commands.DeletePurchaseOrder
{
    public class DeletePurchaseOrderCommandHandler : IRequestHandler<DeletePurchaseOrderCommand, Unit>
    {
        private readonly IPurchaseOrderRepository purchaseOrderRepository;

        public DeletePurchaseOrderCommandHandler(IPurchaseOrderRepository purchaseOrderRepository)
        {
            this.purchaseOrderRepository = purchaseOrderRepository;
        }
        public async Task<Unit> Handle(DeletePurchaseOrderCommand request, CancellationToken cancellationToken)
        {
            var purchaseOrderToDelete = await purchaseOrderRepository.GetByIdAsync(request.Id); 

            if(purchaseOrderToDelete is null)
            {
                throw new NotFoundException(nameof(PurchaseOrder), request.Id); 
            }

            await purchaseOrderRepository.DeleteAsync(purchaseOrderToDelete);
            return Unit.Value;
        }
    }
}
