using Compras.Application.Features.Supplier.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Supplier.Commands.CreateSupplier;

public class CreateSupplierCommand:BaseSupplier, IRequest<int>
{
   
}
