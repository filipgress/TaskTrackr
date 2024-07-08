using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskTrackr.Dtos.Task;

namespace TaskTrackr.Models;

public class Task
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)] public string Name { get; set; }
    [MaxLength(500)] public string Description { get; set; } 
    public TaskPriority Priority { get; set; }
    [Range(1, 10)] public int Difficulty { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? CompletedAt { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }
    
    public int ProjectId { get; set; }
    public Project Project { get; set; }
    
    // Task can be unassigned
    public string? UserId { get; set; }
    public User? User { get; set; }
    
    public Task() {}

    public Task(CreateTaskDto taskDto, int projectId)
    {
        Name = taskDto.Name;
        Description = taskDto.Description;
        Priority = taskDto.Priority;
        Difficulty = taskDto.Difficulty;
        DueDate = taskDto.DueDate;
        
        ProjectId = projectId;
        UserId = taskDto.UserId;
    }

    public void Update(UpdateTaskDto taskDto)
    {
        if (taskDto.Name != null)
            Name = taskDto.Name;
        
        if (taskDto.Description != null)
            Description = taskDto.Description;
        
        if (taskDto.Priority.HasValue)
            Priority = taskDto.Priority.Value;
        
        if (taskDto.Difficulty.HasValue)
            Difficulty = taskDto.Difficulty.Value;
        
        if (taskDto.DueDate.HasValue)
            DueDate = taskDto.DueDate.Value;
        
        if (taskDto.CompletedAt.HasValue)
            CompletedAt = taskDto.CompletedAt;
        
        if (taskDto.UserId != null)
            UserId = taskDto.UserId;
    }
}