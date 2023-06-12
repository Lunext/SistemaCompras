
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.CreateMeasureUnit;

public class CreateMeasureUnitCommandHandler : IRequestHandler<CreateMeasureUnitCommand, int>
{
    private readonly IMapper mapper;
    private readonly IMeasureUnitRepository measureUnitRepository;

    public CreateMeasureUnitCommandHandler(IMapper mapper, IMeasureUnitRepository measureUnitRepository)
    {
        this.mapper = mapper;
        this.measureUnitRepository = measureUnitRepository;
    }
    public async Task<int> Handle(CreateMeasureUnitCommand request, CancellationToken cancellationToken)
    {
        var measureUnitToCreate = mapper.Map<Domain.Domains.MeasureUnit>(request);

        await measureUnitRepository.CreateAsync(measureUnitToCreate);

        return measureUnitToCreate.Id;
    }
}
