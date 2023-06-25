using Compras.Application.Features.PurchaseOrder.Commands.CreatePurchaseOrder;
using Compras.Application.Features.PurchaseOrder.Commands.DeletePurchaseOrder;
using Compras.Application.Features.PurchaseOrder.Commands.UpdatePurchaseOrder;
using Compras.Application.Features.PurchaseOrder.Queries.GetAllPurchaseOrders;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersByItsAvailability;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersFilteredByDate;
using Compras.Application.Features.PurchaseOrder.Queries.GetPurchaseOrdersWithDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly IMediator mediator;

        public PurchaseOrdersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PurchaseOrderDto>> Get()
        {
            var purchaseOrders = await mediator.Send(new GetPurchaseOrdersQuery());

            return purchaseOrders;
        }
        [HttpGet("get-by-availability")]
        public async Task<List<PurchasedOrderFilteredByAvailabilityDto>> GetByAvailability(bool isAvailable)
        {
            var purchaseOrdersFiltered = await mediator.Send(new GetPurchaseOrdersFilteredByItsAvailabilityQuery(isAvailable));
            return purchaseOrdersFiltered;

        }

        [HttpGet("filtered-by-date")]
        public async Task<List<PurchaseOrdersFilteredByDateDto>> GetByDate(DateTime firstDate, DateTime lastDate)
        {
            var purchaseOrdersFiltered= await mediator.Send(new GetPurchaseOrdersFilteredByDateQuery(firstDate, lastDate));

            return purchaseOrdersFiltered;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderDetailsDto>> Get (int id)
        {
            var purchaseOrder = await mediator.Send(new GetPurcharseOrderDetailsQuery(id)); 
            return Ok(purchaseOrder);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Post(CreatePurchaseOrderCommand purchaseOrder)
        {
            var response = await mediator.Send(purchaseOrder);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        [HttpPut("{id}")]


        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Put(UpdatePurchaseOrderCommand purchaseOrder)
        {
            await mediator.Send(purchaseOrder);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeletePurchaseOrderCommand { Id = id }; 
            await mediator.Send(command);
            return NoContent(); 
        }
    }
}
