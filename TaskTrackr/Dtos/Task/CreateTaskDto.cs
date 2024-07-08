using System.ComponentModel.DataAnnotations;
using TaskTrackr.Models;

namespace TaskTrackr.Dtos.Task;

public class CreateTaskDto
{
    [MinLength(5)] [MaxLength(50)]
    public required string Name { get; set; }
    
    [MaxLength(500)]
    public required string Description { get; set; } 
    public required TaskPriority Priority { get; set; }
    
    [Range(1, 10)]
    public required int Difficulty { get; set; }
    public required DateTime DueDate { get; set; }
    
    public string? UserId { get; set; }
}