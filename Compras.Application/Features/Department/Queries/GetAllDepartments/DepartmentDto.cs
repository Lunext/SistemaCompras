using Compras.Application.Features.Department.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Department.Queries.GetAllDepartments;

public class DepartmentDto: BaseDepartment
{
    public int Id { get; set;  }
}
