using System.ComponentModel.DataAnnotations;
using TaskTrackr.Models;

namespace TaskTrackr.Dtos.Task;

public class UpdateTaskDto
{
    [MinLength(5)] [MaxLength(50)]
    public string? Name { get; set; }
    
    [MaxLength(500)]
    public string? Description { get; set; } 
    public TaskPriority? Priority { get; set; }
    
    [Range(1, 10)]
    public int? Difficulty { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }
    
    public string? UserId { get; set; }
}