
using Compras.Domain.Common;

namespace Compras.Application.Features.AccountingEntry.Queries;

public class AccountingEntriesDto
{
    public int Id { get; set; } 
    public string Descripcion { get; set; } = string.Empty;
    public int CuentaContable { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string TipoMovimiento { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;  
    public int Auxiliar { get; set; }
    public decimal Monto { get; set; }
}

