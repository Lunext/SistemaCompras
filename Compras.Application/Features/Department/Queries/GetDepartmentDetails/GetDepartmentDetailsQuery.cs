

using MediatR;

namespace Compras.Application.Features.Department.Queries.GetDepartmentDetails;

public record GetDepartmentDetailsQuery(int Id): IRequest<DepartmentDetailsDto>;


