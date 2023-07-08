using Compras.Application.Features.PurchaseOrder.Shared;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByCost;

public class PurchaseOrderByCostDto: BasePurchaseOrder
{
    public int Id { get; set; }
    public decimal Total { get; set; }
}
