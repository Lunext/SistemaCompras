using Compras.Application.Features.Supplier.Commands.CreateSupplier;
using Compras.Application.Features.Supplier.Commands.DeleteSupplier;
using Compras.Application.Features.Supplier.Commands.UpdateSupplier;
using Compras.Application.Features.Supplier.Queries.GetAllSuppliers;
using Compras.Application.Features.Supplier.Queries.GetSupplierDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly IMediator mediator;

        public SuppliersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<SupplierDto>> Get()
        {
            var suppliers = await mediator.Send(new GetSuppliersQuery());
            return suppliers;

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SupplierDetailsDto>> Get(int id)
        {
            var supplier = await mediator.Send(new GetSupplierDetailsQuery(id));
            return Ok(supplier);
        }


        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreateSupplierCommand supplierCommand)
        {
            var response = await mediator.Send(supplierCommand);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateSupplierCommand supplier)
        {
            await mediator.Send(supplier);
            return NoContent();
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteSupplierCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }

    }
}
