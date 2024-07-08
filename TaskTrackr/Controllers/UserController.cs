using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskTrackr.Dtos.User;
using TaskTrackr.Interfaces;
using TaskTrackr.IO;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Controllers;

[Route("user")]
[ApiController]
// [Authorize(Roles = "Admin")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepo;

    public UserController(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<UserDto>>> GetAll([FromQuery] UserQuery query)
    {
        try
        {
            var users = await _userRepo.GetAllAsync(query);
            return users.Select(user => new UserDto(user)).ToList();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetById([FromRoute] string id)
    {
        try
        {
            var user = await _userRepo.GetByIdAsync(id);
            return user == null 
                ? NotFound($"User with id '{id}' was not found!")
                : new UserDto(user);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }

    // [HttpPost]
    // [ProducesResponseType(StatusCodes.Status201Created)]
    // [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<UserDto>> Create([FromBody] CreateUserDto userDto)
    // {
    //     var user = await _userRepo.CreateAsync(userDto);
    //     return await GetById(user.Id);
    // }
    
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> Update([FromRoute] string id, [FromBody] UpdateUserDto userDto)
    {
        try
        {
            var user = await _userRepo.UpdateAsync(id, userDto);
            return user == null
                ? NotFound($"User with id '{id}' was not found!")
                : new UserDto(user);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<NotFound>(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete([FromRoute] string id)
    {
        try
        {
            var user = await _userRepo.DeleteAsync(id);
            return user == null
                ? NotFound($"User with id '{id}' was not found!")
                : NoContent();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
}