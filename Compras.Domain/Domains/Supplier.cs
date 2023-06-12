
using Compras.Domain.Common;

namespace Compras.Domain.Domains;

public class Supplier: BaseEntity
{
    public string DominicanID { get; set; } = string.Empty; 
    public string CompanyName { get; set;} = string.Empty;
}
