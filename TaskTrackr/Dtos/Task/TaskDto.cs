using TaskTrackr.Models;

namespace TaskTrackr.Dtos.Task;

public class TaskDto
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; } 
    public TaskPriority Priority { get; set; }
    public int Difficulty { get; set; }
    
    public DateTime DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public int ProjectId { get; set; }
    public string? UserId { get; set; }

    public TaskDto(Models.Task task)
    {
        Id = task.Id;
        Name = task.Name;
        Description = task.Description;
        Priority = task.Priority;
        Difficulty = task.Difficulty;
        
        DueDate = task.DueDate;
        CompletedAt = task.CompletedAt;
        CreatedAt = task.CreatedAt;
        
        ProjectId = task.ProjectId;
        UserId = task.UserId;
    }
}