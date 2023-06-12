

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Queries.GetAllMeasureUnits;
public class GetMeasureUnitsQueryHandler : IRequestHandler<GetMeasureUnitsQuery, List<MeasureUnitsDto>>
{
    private readonly IMapper mapper;
    private readonly IMeasureUnitRepository measureUnitRepository;

    public GetMeasureUnitsQueryHandler(IMapper mapper, IMeasureUnitRepository measureUnitRepository)
    {
        this.mapper = mapper;
        this.measureUnitRepository = measureUnitRepository;
    }

    public async Task<List<MeasureUnitsDto>> Handle(GetMeasureUnitsQuery request, CancellationToken cancellationToken)
    {
        var measureUnits = await  measureUnitRepository.GetAllAsync(); 

        var mappedToMeasureUnitsDto= mapper.Map<List<MeasureUnitsDto>>(measureUnits);

        return mappedToMeasureUnitsDto;
    }
}
