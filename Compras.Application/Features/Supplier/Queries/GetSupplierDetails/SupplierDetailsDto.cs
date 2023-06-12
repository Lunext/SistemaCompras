using Compras.Application.Features.Supplier.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Application.Features.Supplier.Queries.GetSupplierDetails;

public class SupplierDetailsDto:BaseSupplier
{
    public int Id { get; set; }
    public DateTime? DateCreated {  get; set; } 
    public DateTime? DateModified { get; set; } 
}
