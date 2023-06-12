
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Commands.DeleteMeasureUnit;

public class DeleteMeasureUnitCommand:IRequest<Unit>
{
    public int Id { get; set; } 
}
