
using MediatR;

namespace Compras.Application.Features.Supplier.Queries.GetAllSuppliers;

public record GetSuppliersQuery: IRequest<List<SupplierDto>>;

