using Compras.Application.Features.PurchaseOrder.Shared;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersWithDetails;

public class PurchaseOrderDetailsDto: BasePurchaseOrder
{
    public int Id { get; set;}

    public DateTime? DateCreated {  get; set;}

    public DateTime? DateModified { get; set;}

}



