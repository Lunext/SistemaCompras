

using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Compras.Persistence.DatabaseContext;

namespace Compras.Persistence.Repositories;

public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(ComprasDatabaseContext context) : base(context)
    {
    }
}
