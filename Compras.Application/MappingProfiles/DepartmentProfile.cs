using AutoMapper;
using Compras.Application.Features.Department.Commands.CreateDepartment;
using Compras.Application.Features.Department.Commands.UpdateDepartment;
using Compras.Application.Features.Department.Queries.GetAllDepartments;
using Compras.Application.Features.Department.Queries.GetDepartmentDetails;
using Compras.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.MappingProfiles;

public class DepartmentProfile: Profile
{

    public DepartmentProfile()
    {
        CreateMap<DepartmentDto, Department>().ReverseMap();
        CreateMap<Department, DepartmentDetailsDto>();
        CreateMap<CreateDepartmentCommand, Department>();
        CreateMap<UpdateDepartmentCommand, Department>(); 
    }
}
