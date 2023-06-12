
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetailsDto;

public class GetMeasureUnitDetailsQueryHandler : IRequestHandler<GetMeasureUnitDetailsQuery,MeasureUnitDetailsDto>
{
    private readonly IMapper mapper;
    private readonly IMeasureUnitRepository measureUnitRepository;

    public GetMeasureUnitDetailsQueryHandler(IMapper mapper, IMeasureUnitRepository measureUnitRepository)
    {
        this.mapper = mapper;
        this.measureUnitRepository = measureUnitRepository;
    }


    async Task<MeasureUnitDetailsDto> IRequestHandler<GetMeasureUnitDetailsQuery, MeasureUnitDetailsDto>.Handle(GetMeasureUnitDetailsQuery request, CancellationToken cancellationToken)
    {
        var measureUnit = await measureUnitRepository.GetByIdAsync(request.Id); 

        var measureUnitMappedToDto=mapper.Map<MeasureUnitDetailsDto>(measureUnit);

        return measureUnitMappedToDto;
    }
}
