using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersByItsAvailability;

public record GetPurchaseOrdersFilteredByItsAvailabilityQuery(bool IsAvailable)
    :IRequest<List<PurchasedOrderFilteredByAvailabilityDto>>;
