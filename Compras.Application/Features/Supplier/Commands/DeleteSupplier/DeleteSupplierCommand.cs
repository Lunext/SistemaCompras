using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Supplier.Commands.DeleteSupplier;

public class DeleteSupplierCommand:IRequest<Unit>
{
    public int Id { get; set; } 

}
