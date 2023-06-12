using Compras.Application.Features.Department.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Department.Commands.UpdateDepartment;

public class UpdateDepartmentCommand:BaseDepartment, IRequest<Unit>
{
    public int Id { get; set;}
}
