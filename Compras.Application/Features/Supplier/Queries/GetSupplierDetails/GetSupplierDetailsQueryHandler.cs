

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Supplier.Queries.GetSupplierDetails;

public class GetSupplierDetailsQueryHandler : IRequestHandler<GetSupplierDetailsQuery, SupplierDetailsDto>
{
    private readonly IMapper mapper;
    private readonly ISupplierRepository supplierRepository;

    public GetSupplierDetailsQueryHandler(IMapper mapper, ISupplierRepository supplierRepository )
    {
        this.mapper = mapper;
        this.supplierRepository = supplierRepository;
    }
    public async Task<SupplierDetailsDto> Handle(GetSupplierDetailsQuery request, CancellationToken cancellationToken)
    {
        var supplier = await supplierRepository.GetByIdAsync(request.Id);
        var supplierMappedToDto = mapper.Map<SupplierDetailsDto>(supplier);

        return supplierMappedToDto;
    }



}
