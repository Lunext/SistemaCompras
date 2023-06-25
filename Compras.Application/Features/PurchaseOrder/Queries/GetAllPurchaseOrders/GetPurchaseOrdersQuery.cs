using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetAllPurchaseOrders
{
   public record class GetPurchaseOrdersQuery:IRequest<List<PurchaseOrderDto>>;  
}
