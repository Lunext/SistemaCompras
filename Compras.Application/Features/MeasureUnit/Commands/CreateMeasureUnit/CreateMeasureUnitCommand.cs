
using Compras.Application.Features.MeasureUnit.Shared;
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.CreateMeasureUnit;

public class CreateMeasureUnitCommand: BaseMeasureUnit, IRequest<int>
{
}
