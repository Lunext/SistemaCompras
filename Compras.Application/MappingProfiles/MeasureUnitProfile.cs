using AutoMapper;
using Compras.Application.Features.MeasureUnit.Commands.CreateMeasureUnit;
using Compras.Application.Features.MeasureUnit.Commands.UpdateMeasureUnit;
using Compras.Application.Features.MeasureUnit.Queries.GetAllMeasureUnits;
using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;
using Compras.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.MappingProfiles;

public class MeasureUnitProfile:Profile
{
    public MeasureUnitProfile()
    {
        CreateMap<MeasureUnitsDto, MeasureUnit>().ReverseMap();
        CreateMap<MeasureUnit, MeasureUnitDetailsDto>();
        CreateMap<CreateMeasureUnitCommand, MeasureUnit>();
        CreateMap<UpdateMeasureUnitCommand, MeasureUnit>();
        
    }
}


