
using Compras.Application.Features.MeasureUnit.Shared;

namespace Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;

public class MeasureUnitDetailsDto:BaseMeasureUnit
{
    public int Id { get; set;}

    public DateTime? DateCreated { get; set;}    

    public DateTime? DateModified { get; set; }
}
