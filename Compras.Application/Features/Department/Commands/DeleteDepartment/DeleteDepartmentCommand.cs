

using MediatR;

namespace Compras.Application.Features.Department.Commands.DeleteDepartment;

public class DeleteDepartmentCommand: IRequest<Unit>
{
    public int Id { get; set; }
}
