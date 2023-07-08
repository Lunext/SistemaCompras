
using AutoMapper;
using Compras.Application.Contracts.Persistence;
using MediatR;

namespace Compras.Application.Features.AccountingEntry.Queries;

public class GetAccountingEntriesByAuxQueryHandler :
    IRequestHandler<GetAccountingEntriesByAuxQuery, 
        IEnumerable<AccountingEntriesDto>>
{
    private readonly IMapper mapper;
    private readonly IAccountingEntryRepository accountingEntryRepository;

    public GetAccountingEntriesByAuxQueryHandler(IMapper mapper,
        IAccountingEntryRepository accountingEntryRepository)
    {
        this.mapper = mapper;
        this.accountingEntryRepository = accountingEntryRepository;
    }
    public async Task<IEnumerable<AccountingEntriesDto>> Handle(GetAccountingEntriesByAuxQuery request, CancellationToken cancellationToken)
    {
        var accountingEntries = await accountingEntryRepository.GetAccountingEntriesFilteredByAux(request.auxId);

        var accountingEntriesMappedToDto = mapper.Map<List<AccountingEntriesDto>>(accountingEntries);

        return accountingEntriesMappedToDto;
    }
}
