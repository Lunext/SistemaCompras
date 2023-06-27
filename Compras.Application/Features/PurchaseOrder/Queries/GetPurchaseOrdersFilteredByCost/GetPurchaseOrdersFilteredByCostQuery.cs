

using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByCost;

public record  GetPurchaseOrdersFilteredByCostQuery(decimal firstCost, decimal lastCost) : IRequest<List<PurchaseOrderByCostDto>>;

