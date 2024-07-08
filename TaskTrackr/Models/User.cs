using Microsoft.AspNetCore.Identity;
using TaskTrackr.Dtos.Account;
using TaskTrackr.Dtos.User;

namespace TaskTrackr.Models;

public sealed class User : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }

    public ICollection<Project> Projects { get; set; } = [];
    public ICollection<Task> Tasks { get; set; } = [];
    
    public User() {}

    public User(RegisterDto registerDto)
    {
        Email = registerDto.Email;
        UserName = registerDto.UserName;
    }
    
    public void Update(UpdateUserDto userDto)
    {
        if (userDto.Email != null)
            Email = userDto.Email;
        
        if (userDto.UserName != null)
            UserName = userDto.UserName;
    }
}