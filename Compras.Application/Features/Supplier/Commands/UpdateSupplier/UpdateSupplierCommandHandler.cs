using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Supplier.Commands.UpdateSupplier;

public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, Unit>
{
    private readonly IMapper mapper;
    private readonly ISupplierRepository supplierRepository;

    public UpdateSupplierCommandHandler(IMapper mapper, ISupplierRepository supplierRepository )
    {
        this.mapper = mapper;
        this.supplierRepository = supplierRepository;
    }
    public async Task<Unit> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
    {
        var supplierToUpdate = mapper.Map<Domain.Domains.Supplier>(request); 

        await supplierRepository.UpdateAsync(supplierToUpdate);

        return Unit.Value;  
    }

}
