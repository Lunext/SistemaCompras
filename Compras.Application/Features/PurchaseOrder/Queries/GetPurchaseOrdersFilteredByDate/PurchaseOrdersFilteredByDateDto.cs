
using Compras.Application.Features.PurchaseOrder.Shared;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByDate;

public class PurchaseOrdersFilteredByDateDto:BasePurchaseOrder
{
    public int Id { get; set;}
    public decimal Total { get; set; }
}


