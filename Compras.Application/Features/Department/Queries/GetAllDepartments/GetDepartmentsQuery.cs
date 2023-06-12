

using MediatR;

namespace Compras.Application.Features.Department.Queries.GetAllDepartments;

public record GetDepartmentsQuery: IRequest<List<DepartmentDto>>;



