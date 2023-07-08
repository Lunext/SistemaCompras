using Compras.Application.Features.PurchaseOrder.Shared;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersByItsAvailability;

public class PurchasedOrderFilteredByAvailabilityDto:BasePurchaseOrder
{
    public int Id { get; set;}
    public decimal Total { get; set; }
}
