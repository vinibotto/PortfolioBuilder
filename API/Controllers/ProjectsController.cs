using Application.Core;
using Application.Projects;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Diagnostics;

namespace API.Controllers
{
    public class ProjectsController : BaseApiController
    {
        private readonly IMediator _mediator;
        public ProjectsController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects() 
        { 
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Result<Project>> GetProject(Guid id)
        {
            return await _mediator.Send(new Details.Query {Id=id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(Project project)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Project = project }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditProject(Guid id, Project project)
        {
            project.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Project = project }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
