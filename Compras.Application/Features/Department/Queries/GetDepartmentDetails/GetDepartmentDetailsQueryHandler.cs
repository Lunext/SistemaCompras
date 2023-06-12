

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Department.Queries.GetDepartmentDetails;

internal class GetDepartmentDetailsQueryHandler : IRequestHandler<GetDepartmentDetailsQuery, DepartmentDetailsDto>
{
    private readonly IMapper mapper;
    private readonly IDepartmentRepository departmentRepository;

    public GetDepartmentDetailsQueryHandler(IMapper mapper, IDepartmentRepository departmentRepository)
    {
        this.mapper = mapper;
        this.departmentRepository = departmentRepository;
    }

    public async Task<DepartmentDetailsDto> Handle(GetDepartmentDetailsQuery request, CancellationToken cancellationToken)
    {
        var department = await departmentRepository.GetByIdAsync(request.Id);

        var mappedDepartmentToDto = mapper.Map<DepartmentDetailsDto>(department);

        return mappedDepartmentToDto; 
    }
}
