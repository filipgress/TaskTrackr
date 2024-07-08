using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTrackr.Dtos.Account;
using TaskTrackr.Dtos.User;
using TaskTrackr.Interfaces;
using TaskTrackr.IO;
using TaskTrackr.Models;

namespace TaskTrackr.Controllers;

[Route("account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<User> _signinManager;
    private readonly ITaskRepository _taskRepo;

    public AccountController(
        ITokenService tokenService, 
        UserManager<User> manager,
        SignInManager<User> signInManager,
        ITaskRepository taskRepo)
    {
        _userManager = manager;
        _tokenService = tokenService;
        _signinManager = signInManager;
        _taskRepo = taskRepo;
    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<UserTokenDto>> LogIn([FromBody] LoginDto loginDto)
    {
        try
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName.ToLower() == loginDto.UserName.ToLower());
            if (user == null)
                return Unauthorized("Bad username or password!");

            var res = await _signinManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!res.Succeeded)
                return Unauthorized("Bad username or password!");

            var role = await _userManager.GetRolesAsync(user);
            Console.WriteLine(role[0]);
            return new UserTokenDto
            {
                UserName = user.UserName,
                Token = _tokenService.CreateToken(user, role[0])
            };
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserTokenDto>> Register([FromBody] RegisterDto registerDto)
    {
        try
        {
            var user = new User(registerDto);

            var createdUser = await _userManager.CreateAsync(user, registerDto.Password);
            if (!createdUser.Succeeded)
                return StatusCode(500, createdUser.Errors);

            var roleRes = await _userManager.AddToRoleAsync(user, "User");
            if (!roleRes.Succeeded)
                return StatusCode(500, roleRes.Errors);

            return new UserTokenDto
            {
                UserName = user.UserName,
                Token = _tokenService.CreateToken(user, "User")
            };
        }
        catch (DbUpdateException ex)
        {
            return StatusCode(500, $"User with this username already exists");
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }

    [HttpGet("profile")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<UserDto>> GetAccount()
    {
        try
        {
            var userId = User.FindFirstValue("sub");
            if (userId == null)
                return Unauthorized("Unauthorized, wrong token!");

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            return new UserDto(user);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
    
    [HttpPut]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType<BadRequest>(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserDto>> EditAccount([FromBody] UpdateUserDto userDto)
    {
        try
        {
            var userId = User.FindFirstValue("sub");
            if (userId == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            user.Update(userDto);

            await _userManager.UpdateAsync(user);
            return new UserDto(user);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }

    [HttpDelete]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> DeleteAccount()
    {
        try
        {
            var userId = User.FindFirstValue("sub");
            if (userId == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            user.DeletedAt = DateTime.Now;
            
            await _userManager.UpdateAsync(user);
            return NoContent();
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }

    [HttpGet("stats")]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<AccountStatsDto>> GetAccountStats()
    {
        try
        {
            var userId = User.FindFirstValue("sub");
            if (userId == null)
                return Unauthorized("Unauthorized, wrong token!");
            
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return Unauthorized("Unauthorized, wrong token!");

            var userTasks = await _taskRepo.GetByUserIdAsync(userId);

            return new AccountStatsDto(userTasks);
        }
        catch (Exception ex)
        {
            Logger.InternalError(ex);
            return StatusCode(500, "Opps! It's not you it's us.");
        }
    }
}