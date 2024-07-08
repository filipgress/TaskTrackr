using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Dtos.Account;

public class LoginDto
{ 
    [MaxLength(50)] 
    public required string UserName { get; set; } 
    
    [MinLength(8)]
    public required string Password { get; set; }
}