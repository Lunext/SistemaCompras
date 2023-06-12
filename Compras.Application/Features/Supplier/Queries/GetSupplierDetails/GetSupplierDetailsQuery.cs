
using MediatR;

namespace Compras.Application.Features.Supplier.Queries.GetSupplierDetails;

public record GetSupplierDetailsQuery(int Id):IRequest<SupplierDetailsDto>;

