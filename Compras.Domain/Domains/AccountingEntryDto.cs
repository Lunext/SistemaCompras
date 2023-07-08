namespace Compras.Domain.Domains;

public class AccountingEntryDto
{
    public string descripcion { get; set; } = string.Empty;
   
    public int auxiliar { get; set; } = 7;
    public int cuentaDB { get; set; }
    public int cuentaCR { get; set; }
    public decimal monto { get; set; }

}