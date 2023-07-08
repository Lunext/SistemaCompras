

using Compras.Domain.Common;
using Compras.Domain.Domains;
using MediatR;

namespace Compras.Application.Features.AccountingEntry.Commands;

public class SendAccountingEntriesCommand : IRequest<AccountingEntryDto>
{

    public string Descripcion { get; set; } = string.Empty;
    public int Auxiliar { get; set; }
    public int CuentaDB { get; set; }
    public int CuentaCR { get; set;}
    public decimal Monto { get; set;}

}
