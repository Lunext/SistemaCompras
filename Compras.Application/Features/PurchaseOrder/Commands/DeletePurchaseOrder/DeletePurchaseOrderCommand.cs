using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Commands.DeletePurchaseOrder;


public class DeletePurchaseOrderCommand:IRequest<Unit>
{
    public int Id { get; set;}
}
