

using AutoMapper;
using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using MediatR;

namespace Compras.Application.Features.AccountingEntry.Commands;

public class SendAccountingEntryCommandHandler : IRequestHandler<SendAccountingEntriesCommand,
    AccountingEntryDto>
{
    private readonly IMapper mapper;
    private readonly IAccountingEntryRepository accountingEntryRepository;

    public SendAccountingEntryCommandHandler(IMapper mapper, IAccountingEntryRepository accountingEntryRepository)
    {
        this.mapper = mapper;
        this.accountingEntryRepository = accountingEntryRepository;
    }


    public async Task<AccountingEntryDto> Handle(SendAccountingEntriesCommand request, CancellationToken cancellationToken)
    {

        var accountingEntryToSend = mapper.Map<Domain.Domains.AccountingEntryDto>(request);

        await accountingEntryRepository.SendAccountingEntryToContabilidad(accountingEntryToSend); 

      

        return accountingEntryToSend;
       
    }
}
