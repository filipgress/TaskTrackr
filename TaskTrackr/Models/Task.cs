using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Models;

public class Task
{
    public int Id { get; set; }

    [MaxLength(50)] public required string Name { get; set; }
    [MaxLength(500)]public required string Description { get; set; } 
    public required TaskPriority Priority { get; set; }
    [Range(1, 10)] public required int Difficulty { get; set; }
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public required DateTime DueDate { get; set; }
    
    public bool IsCompleted { get; set; }
    public bool IsDeleted { get; set; }
    
    public int ProjectId { get; set; }
    public required Project Project { get; set; }
}