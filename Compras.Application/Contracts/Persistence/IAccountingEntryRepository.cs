using Compras.Domain.Domains;

namespace Compras.Application.Contracts.Persistence;

public interface IAccountingEntryRepository 
{
    Task SendAccountingEntryToContabilidad(AccountingEntryDto accountingEntry);

    Task <IEnumerable<AccountingEntry>> GetAccountingEntriesFilteredByAux(int AuxId);
}