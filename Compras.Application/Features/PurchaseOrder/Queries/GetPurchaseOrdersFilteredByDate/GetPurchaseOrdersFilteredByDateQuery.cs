using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByDate;

public record GetPurchaseOrdersFilteredByDateQuery(DateTime firtDate, DateTime lastDate)
    :IRequest<List<PurchaseOrdersFilteredByDateDto>>;
