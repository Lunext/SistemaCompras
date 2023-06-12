

using Compras.Application.Contracts.Persistence;
using Compras.Application.Exceptions;
using MediatR;

namespace Compras.Application.Features.Supplier.Commands.DeleteSupplier;

public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, Unit>
{
    private readonly ISupplierRepository supplierRepository;

    public DeleteSupplierCommandHandler(ISupplierRepository supplierRepository)
    {
        this.supplierRepository = supplierRepository;
    }
    public async Task<Unit> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
    {
        var supplierToDelete = await supplierRepository.GetByIdAsync(request.Id); 

        if (supplierToDelete is null)
        {
            throw new NotFoundException(nameof(Supplier), request.Id); 
        }

        await supplierRepository.DeleteAsync(supplierToDelete);

        return Unit.Value; 
    }
}
