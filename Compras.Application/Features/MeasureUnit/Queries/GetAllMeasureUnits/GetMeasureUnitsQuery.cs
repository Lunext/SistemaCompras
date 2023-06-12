
using MediatR;

namespace Compras.Application.Features.MeasureUnit.Queries.GetAllMeasureUnits;

public record GetMeasureUnitsQuery: IRequest<List<MeasureUnitsDto>>;

