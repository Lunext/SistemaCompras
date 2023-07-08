using Compras.Domain.Common;

namespace Compras.Domain.Domains;




public class AccountingEntry : BaseEntity
{
    public string Descripcion { get; set; } = string.Empty;

    public int CuentaContable { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string TipoMovimiento { get; set; } = string.Empty;
    public int Auxiliar { get; set; } = 7; 
    public string? Estado { get;  set; }
    public int CuentaDB { get; set; }    
    public int CuentaCR { get; set; }
    public decimal Monto { get; set; }

}
