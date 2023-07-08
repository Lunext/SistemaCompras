using AutoMapper;
using Compras.Application.Features.AccountingEntry.Commands;
using Compras.Application.Features.AccountingEntry.Queries;
using Compras.Domain.Domains;

namespace Compras.Application.MappingProfiles;

public class AccountingEntryProfile : Profile
{
    public AccountingEntryProfile()
    {
        CreateMap<AccountingEntriesDto, AccountingEntry>().ReverseMap();
        CreateMap<SendAccountingEntriesCommand, AccountingEntryDto>();
    }
}


