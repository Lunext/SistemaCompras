

using AutoMapper;
using Compras.Application.Features.PurchaseOrder.Commands.CreatePurchaseOrder;
using Compras.Application.Features.PurchaseOrder.Commands.UpdatePurchaseOrder;
using Compras.Application.Features.PurchaseOrder.Queries.GetAllPurchaseOrders;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersByItsAvailability;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByCost;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByDate;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersWithDetails;
using Compras.Domain.Domains;

namespace Compras.Application.MappingProfiles;

public class PurchaseOrderProfile : Profile
{
    public PurchaseOrderProfile()
    {
        CreateMap<PurchaseOrderDto, PurchaseOrder>().ReverseMap();
        CreateMap<PurchaseOrder, PurchaseOrderDetailsDto>();
        CreateMap<CreatePurchaseOrderCommand, PurchaseOrder>();
        CreateMap<UpdatePurchaseOrderCommand, PurchaseOrder>();
        CreateMap<PurchasedOrderFilteredByAvailabilityDto, PurchaseOrder>().ReverseMap();
        CreateMap<PurchaseOrdersFilteredByDateDto, PurchaseOrder>().ReverseMap();
        CreateMap<PurchaseOrderByCostDto, PurchaseOrder>().ReverseMap();          

    }
}