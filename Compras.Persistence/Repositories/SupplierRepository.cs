using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Compras.Persistence.DatabaseContext;

namespace Compras.Persistence.Repositories;

public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
{
    public SupplierRepository(ComprasDatabaseContext context) : base(context)
    {
    }
}
