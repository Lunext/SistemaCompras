

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Department.Queries.GetAllDepartments;

public class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, List<DepartmentDto>>
{
    private readonly IMapper mapper;
    private readonly IDepartmentRepository departmentRepository;

    public GetDepartmentsQueryHandler(IMapper mapper, IDepartmentRepository departmentRepository)
    {
        this.mapper = mapper;
        this.departmentRepository = departmentRepository;
    }
  
    public async Task<List<DepartmentDto>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var departments = await departmentRepository.GetAllAsync();

        var mappedDepartmentToList = mapper.Map<List<DepartmentDto>>(departments);

        return mappedDepartmentToList;
    }
}
