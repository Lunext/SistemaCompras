

using Compras.Application.Features.MeasureUnit.Shared;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.UpdateMeasureUnit;

public class UpdateMeasureUnitCommand:BaseMeasureUnit, IRequest<Unit>
{
    public int Id { get; set;}
}
