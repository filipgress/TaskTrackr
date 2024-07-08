using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskTrackr.Dtos.Project;
using TaskTrackr.Interfaces;
using TaskTrackr.IO;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Controllers;

[Route("project")]
[Authorize]
[ApiController]
public class ProjectController : ControllerBase
{
    private readonly IProjectRepository _projectRepo;
    
    public ProjectController(IProjectRepository projectRepo)
    {
        _projectRepo = projectRepo;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<ProjectDto>>> GetAll([FromQuery] QueryObject query)
    {
        try
        {
            var projects = await _projectRepo.GetAllAsync(query);
            return projects.Select(project=> new ProjectDto(project)).ToList();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProjectDto>> GetById([FromRoute] int id)
    {
        try
        {
            var project = await _projectRepo.GetByIdAsync(id);
            return project == null 
                ? NotFound($"Project with id '{id}' was not found!")
                : new ProjectDto(project);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProjectDto>> Create([FromBody] CreateProjectDto projectDto)
    {
        try
        {
            var user = await _projectRepo.CreateAsync(projectDto);
            return await GetById(user.Id);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProjectDto>> Update([FromRoute] int id, [FromBody] UpdateProjectDto projectDto)
    {
        try
        {
            var project = await _projectRepo.UpdateAsync(id, projectDto);
            return project == null
                ? NotFound($"Project with id '{id}' was not found!")
                : new ProjectDto(project);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        try
        {
            var project = await _projectRepo.DeleteAsync(id);
            return project == null
                ? NotFound($"Project with id '{id}' was not found!")
                : NoContent();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
}