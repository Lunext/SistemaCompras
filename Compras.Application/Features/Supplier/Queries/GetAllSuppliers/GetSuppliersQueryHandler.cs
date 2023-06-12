

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Supplier.Queries.GetAllSuppliers;

public class GetSuppliersQueryHandler : IRequestHandler<GetSuppliersQuery, List<SupplierDto>>
{
    private readonly IMapper mapper;
    private readonly ISupplierRepository supplierRepository;


    public GetSuppliersQueryHandler(IMapper mapper, ISupplierRepository supplierRepository)
    {
        this.mapper = mapper;
        this.supplierRepository = supplierRepository;
    }

    public async Task<List<SupplierDto>> Handle(GetSuppliersQuery request, CancellationToken cancellationToken)
    {
        var suppliers = await supplierRepository.GetAllAsync();

        var suppliersmappedToDto = mapper.Map<List<SupplierDto>>(suppliers);

        return suppliersmappedToDto;
    }
}
