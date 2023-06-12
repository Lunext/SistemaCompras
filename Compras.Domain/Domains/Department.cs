using Compras.Domain.Common;

namespace Compras.Domain.Domains;

public class Department: BaseEntity
{
    public string Name { get; set; } = string.Empty;
}
