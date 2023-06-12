

using Compras.Application.Features.Supplier.Shared;
using MediatR;

namespace Compras.Application.Features.Supplier.Commands.UpdateSupplier;

public class UpdateSupplierCommand:BaseSupplier, IRequest<Unit>
{
    public int Id { get; set; }
}
