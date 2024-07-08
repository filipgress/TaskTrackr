using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Dtos.User;

public class UpdateUserDto
{
   [EmailAddress] [MaxLength(50)] 
    public string? Email { get; set; }
    
    [MinLength(5)] [MaxLength(50)] 
    public string? UserName { get; set; }
}