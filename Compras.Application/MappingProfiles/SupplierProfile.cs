

using AutoMapper;
using Compras.Application.Features.Supplier.Commands.CreateSupplier;
using Compras.Application.Features.Supplier.Commands.UpdateSupplier;
using Compras.Application.Features.Supplier.Queries.GetAllSuppliers;
using Compras.Application.Features.Supplier.Queries.GetSupplierDetails;
using Compras.Domain.Domains;

namespace Compras.Application.MappingProfiles;

public class SupplierProfile:Profile
{
    public SupplierProfile()
    {
        CreateMap<SupplierDto, Supplier>().ReverseMap();
        CreateMap<Supplier, SupplierDetailsDto>();
        CreateMap<CreateSupplierCommand, Supplier>(); 
        CreateMap<UpdateSupplierCommand, Supplier>();

        
    }
}
