
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.UpdateMeasureUnit;

public class UpdateMeasureUnitCommandHandler : IRequestHandler<UpdateMeasureUnitCommand, Unit>
{
    private readonly IMapper mapper;
    private readonly IMeasureUnitRepository measureUnitRepository;

    public UpdateMeasureUnitCommandHandler(IMapper mapper, IMeasureUnitRepository measureUnitRepository)
    {
        this.mapper = mapper;
        this.measureUnitRepository = measureUnitRepository;
    }


    public async Task<Unit> Handle(UpdateMeasureUnitCommand request, CancellationToken cancellationToken)
    {
        var measureUnitToUpdate = mapper.Map<Domain.Domains.MeasureUnit>(request); 

        await measureUnitRepository.UpdateAsync(measureUnitToUpdate);

        return Unit.Value; 

    }
}
