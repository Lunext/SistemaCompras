

using MediatR;

namespace Compras.Application.Features.AccountingEntry.Queries;

public record  GetAccountingEntriesByAuxQuery (int auxId): 
    IRequest<IEnumerable<AccountingEntriesDto>>;
