using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Models;

public class User
{
    public int Id { get; set; }
    
    [MaxLength(100)] [EmailAddress] public required string Email { get; set; }
    [MaxLength(50)] public required string FirstName { get; set; }
    [MaxLength(50)] public required string LastName { get; set; } 
    [MaxLength(50)] [MinLength(8)] public required string Password { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = [];
}