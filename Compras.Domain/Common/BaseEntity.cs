namespace Compras.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set;}
    public bool IsAvailable { get; set;}
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set;}
}
