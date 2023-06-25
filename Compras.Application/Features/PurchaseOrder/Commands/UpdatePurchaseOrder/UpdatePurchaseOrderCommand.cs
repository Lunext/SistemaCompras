

using Compras.Application.Features.PurchaseOrder.Shared;
using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Commands.UpdatePurchaseOrder;

public class UpdatePurchaseOrderCommand : BasePurchaseOrder, IRequest<Unit>
{
    public int Id { get; set; }

}

