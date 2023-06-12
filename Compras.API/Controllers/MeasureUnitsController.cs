using Compras.Application.Features.MeasureUnit.Commands.CreateMeasureUnit;
using Compras.Application.Features.MeasureUnit.Commands.DeleteMeasureUnit;
using Compras.Application.Features.MeasureUnit.Commands.UpdateMeasureUnit;
using Compras.Application.Features.MeasureUnit.Queries.GetAllMeasureUnits;
using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetails;
using Compras.Application.Features.MeasureUnit.Queries.GetMeasureUnitDetailsDto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureUnitsController : ControllerBase
    {
        private readonly IMediator mediator;

        public MeasureUnitsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task <List<MeasureUnitsDto>> Get()
        {
            var measureUnits = await mediator.Send(new GetMeasureUnitsQuery()); 
            return measureUnits;

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<MeasureUnitDetailsDto>>Get (int id)
        {
            var measureUnit = await mediator.Send(new GetMeasureUnitDetailsQuery(id));
            return Ok(measureUnit); 

        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreateMeasureUnitCommand measureUnit)
        {
            var response = await mediator.Send(measureUnit);
            return CreatedAtAction(nameof(Get), new { id = response }); 
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateMeasureUnitCommand measureUnit)
        {
            await mediator.Send(measureUnit);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteMeasureUnitCommand { Id = id };
            await mediator.Send(command);
            return NoContent();
        }
    }
}
