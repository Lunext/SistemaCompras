
namespace Compras.Application.Features.Supplier.Shared;

public abstract class BaseSupplier
{
    public string DominicanID { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public bool IsAvailable { get; set; }
}
