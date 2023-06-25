using MediatR;

namespace Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersWithDetails;

public record GetPurcharseOrderDetailsQuery(int Id): IRequest<PurchaseOrderDetailsDto>; 

