
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Supplier.Commands.CreateSupplier;

public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, int>
{
    private readonly IMapper mapper;
    private readonly ISupplierRepository supplierRepository;

    public CreateSupplierCommandHandler(IMapper mapper, ISupplierRepository supplierRepository)
    {
        this.mapper = mapper;
        this.supplierRepository = supplierRepository;
    }


    public async Task<int> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
    {
        var supplierToCreate= mapper.Map<Domain.Domains.Supplier>(request);

        await supplierRepository.CreateAsync(supplierToCreate);

        return supplierToCreate.Id;
    }
}
