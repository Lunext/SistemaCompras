using Compras.Application.Contracts.Persistence;
using Compras.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Department.Commands.DeleteDepartment;

public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand, Unit>
{
    private readonly IDepartmentRepository departmentRepository;

    public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository)
    {
        this.departmentRepository = departmentRepository;
    }


    public async Task<Unit> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        var departmentToDelete = await departmentRepository.GetByIdAsync(request.Id); 

        if(departmentToDelete is null)
        {
            throw new NotFoundException(nameof(Department), request.Id); 
        }
        await departmentRepository.DeleteAsync(departmentToDelete);

        return Unit.Value; 
    }
}
