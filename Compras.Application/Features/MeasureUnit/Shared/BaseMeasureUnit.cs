

namespace Compras.Application.Features.MeasureUnit.Shared;

public abstract class BaseMeasureUnit
{
    public string Description { get; set; } = string.Empty; 
    public bool IsAvailable { get; set; }
}
