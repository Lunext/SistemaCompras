

using Compras.Application.Features.Department.Shared;
using MediatR;

namespace Compras.Application.Features.Department.Commands.CreateDepartment;

public class CreateDepartmentCommand: BaseDepartment, IRequest<int>
{
}
