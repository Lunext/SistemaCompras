

namespace Compras.Application.Features.Department.Shared;

public abstract class BaseDepartment
{
    public string Name { get; set; } = string.Empty; 
    public bool IsAvailable { get; set; }
}
