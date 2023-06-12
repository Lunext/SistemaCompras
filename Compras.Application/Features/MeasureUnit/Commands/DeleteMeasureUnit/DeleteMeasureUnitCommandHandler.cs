
using Compras.Application.Contracts.Persistence;
using Compras.Application.Exceptions;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.DeleteMeasureUnit;

public class DeleteMeasureUnitCommandHandler : IRequestHandler<DeleteMeasureUnitCommand, Unit>
{
    private readonly IMeasureUnitRepository measureUnitRepository;

    public DeleteMeasureUnitCommandHandler(IMeasureUnitRepository measureUnitRepository)
    {
        this.measureUnitRepository = measureUnitRepository;
    }
    public async Task<Unit> Handle(DeleteMeasureUnitCommand request, CancellationToken cancellationToken)
    {
        var MeasureUnitToDelete = await measureUnitRepository.GetByIdAsync(request.Id);

        if (MeasureUnitToDelete is null)
        {
            throw new NotFoundException(nameof(MeasureUnit), request.Id);
        }

        await measureUnitRepository.DeleteAsync(MeasureUnitToDelete);

        return Unit.Value; 
    }
       
}
