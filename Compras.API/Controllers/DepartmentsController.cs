using Compras.Application.Features.Department.Commands.CreateDepartment;
using Compras.Application.Features.Department.Commands.DeleteDepartment;
using Compras.Application.Features.Department.Commands.UpdateDepartment;
using Compras.Application.Features.Department.Queries.GetAllDepartments;
using Compras.Application.Features.Department.Queries.GetDepartmentDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compras.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public DepartmentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        //GET: api<DeparmentsController>
        [HttpGet]
        public async Task<List<DepartmentDto>> Get()
        {
            var departments = await mediator.Send(new GetDepartmentsQuery());
            return departments; 
        }


        //GET api<DeparmentsController>/1
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DepartmentDto>> Get(int id)
        {
            var department = await mediator.Send(new GetDepartmentDetailsQuery(id));
            return Ok(department); 
        }

        //POST api/<DepartmentsController>/1 

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreateDepartmentCommand department)
        {
            var response = await mediator.Send(department);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        //PUT api/<DepartmentsController>/1
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult>Put(UpdateDepartmentCommand department)
        {
            await mediator.Send(department);
            return NoContent(); 
        }

        //DELETE api/<departmentsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task <ActionResult> Delete(int id)
        {
            var command = new DeleteDepartmentCommand { Id = id }; 
            await mediator.Send(command);
            return NoContent(); 
        }

        
    }
}
