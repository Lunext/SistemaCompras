using Compras.Application.Features.AccountingEntry.Commands;
using Compras.Application.Features.AccountingEntry.Queries;
using Compras.Application.Features.Article.Queries.GetArticleDetails;
using Compras.Domain.Domains;
using MediatR;
using Microsoft.AspNetCore.Mvc;




namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingEntriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountingEntriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountingEntriesDto>> Get(int auxId)
        {
            var accountingEntries = await mediator.Send(new GetAccountingEntriesByAuxQuery(auxId));
            return accountingEntries;
        }

      

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<AccountingEntryDto> Post(SendAccountingEntriesCommand accountingEntriesCommand)
        {
            var response = await mediator.Send(accountingEntriesCommand);
            return response;
        }

       

    }
}
