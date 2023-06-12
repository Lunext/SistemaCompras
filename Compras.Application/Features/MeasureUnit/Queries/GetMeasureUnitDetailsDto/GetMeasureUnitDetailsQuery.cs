using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetailsDto;

public record GetMeasureUnitDetailsQuery(int Id): IRequest<MeasureUnitDetailsDto>;
