
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.Department.Commands.CreateDepartment;

public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
{
    private readonly IMapper mapper;
    private readonly IDepartmentRepository departmentRepository;

    public CreateDepartmentCommandHandler(IMapper mapper, IDepartmentRepository departmentRepository)
    {
        this.mapper = mapper;
        this.departmentRepository = departmentRepository;
    }
    public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var departmentToCreate = mapper.Map<Domain.Domains.Department>(request);
        await departmentRepository.CreateAsync(departmentToCreate); 

        return departmentToCreate.Id;
    }
}
