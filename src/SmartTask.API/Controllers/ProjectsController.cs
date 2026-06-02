using MediatR;
using Microsoft.AspNetCore.Mvc;
using SmartTask.Application.Features.Projects.Commands;
using SmartTask.Application.Features.Projects.Queries;
using System.Threading.Tasks;

namespace SmartTask.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllProjectsQuery());

            return Ok(result);
        }
    }
}