using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Department.Commands.UpdateDepartment;

public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, Unit>
{
    private readonly IMapper mapper;
    private readonly IDepartmentRepository departmentRepository;

    public UpdateDepartmentCommandHandler(IMapper mapper, IDepartmentRepository departmentRepository)
    {
        this.mapper = mapper;
        this.departmentRepository = departmentRepository;
    }


    public async Task<Unit> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var departmentToUpdate = mapper.Map<Domain.Domains.Department>(request);
        await departmentRepository.UpdateAsync(departmentToUpdate); 
        return Unit.Value; 
    }
}
