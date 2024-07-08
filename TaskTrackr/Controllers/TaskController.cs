using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskTrackr.Dtos.Task;
using TaskTrackr.Interfaces;
using TaskTrackr.IO;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Controllers;

[Route("task")]
[Authorize]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ITaskRepository _taskRepo;
    private readonly IProjectRepository _projectRepo;
    private readonly IUserRepository _userRepo;

    public TaskController(
        ITaskRepository taskRepo, 
        IProjectRepository projectRepo,
        IUserRepository userRepo)
    {
        _taskRepo = taskRepo;
        _projectRepo = projectRepo;
        _userRepo = userRepo;
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<TaskDto>>> GetAll([FromQuery] TaskQuery query)
    {
        try
        {
            var tasks = await _taskRepo.GetAllAsync(query);
            return tasks.Select(task=> new TaskDto(task)).ToList();
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
    public async Task<ActionResult<TaskDto>> GetById([FromRoute] int id)
    {
        try
        {
            var task = await _taskRepo.GetByIdAsync(id);
            return task == null 
                ? NotFound($"Task with id '{id}' was not found!")
                : new TaskDto(task);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpPost("{projectId:int}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TaskDto>> Create([FromRoute] int projectId, [FromBody] CreateTaskDto taskDto)
    {
        try
        {
            if (!await _projectRepo.Exists(projectId))
                return BadRequest($"Project with id '{projectId}' doesn't exist.");
            
            if (taskDto.UserId != null && !await _userRepo.Exists(taskDto.UserId))
                return BadRequest($"User with id '{taskDto.UserId}' doesn't exist.");
            
            var task = await _taskRepo.CreateAsync(taskDto, projectId);
            return await GetById(task.Id);
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
    public async Task<ActionResult<TaskDto>> Update([FromRoute] int id, [FromBody] UpdateTaskDto taskDto)
    {
        try
        {
            if (taskDto.UserId != null && !await _userRepo.Exists(taskDto.UserId))
                return BadRequest($"User with id '{taskDto.UserId}' doesn't exist.");
            
            var user = await _taskRepo.UpdateAsync(id, taskDto);
            return user == null
                ? NotFound($"Task with id '{id}' was not found!")
                : new TaskDto(user);
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
            var task = await _taskRepo.DeleteAsync(id);
            return task == null
                ? NotFound($"Task with id '{id}' was not found!")
                : NoContent();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
}