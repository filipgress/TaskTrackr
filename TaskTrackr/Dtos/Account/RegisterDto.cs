using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Dtos.Account;

public class RegisterDto
{
   [EmailAddress] [MaxLength(50)] 
    public required string Email { get; set; }
    
    [MinLength(5)] [MaxLength(50)] 
    public required string UserName { get; set; }
    
    [MinLength(8)]
    public required string Password { get; set; }
}