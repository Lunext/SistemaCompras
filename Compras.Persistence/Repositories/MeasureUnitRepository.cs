using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Compras.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Persistence.Repositories
{
    internal class MeasureUnitRepository : GenericRepository<MeasureUnit>, IMeasureUnitRepository
    {
        public MeasureUnitRepository(ComprasDatabaseContext context) : base(context)
        {
        }
    }
}
