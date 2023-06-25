

using Compras.Application.Features.PurchaseOrder.Shared;
using MediatR;


namespace Compras.Application.Features.PurchaseOrder.Commands.CreatePurchaseOrder;

public class CreatePurchaseOrderCommand:BasePurchaseOrder, IRequest<int>
{
}

