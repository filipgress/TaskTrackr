using TaskTrackr.Dtos.Task;

namespace TaskTrackr.Dtos.Project;

public class ProjectDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public ICollection<TaskDto> Tasks { get; set; }

    public ProjectDto(Models.Project project)
    {
        Id = project.Id;
        Name = project.Name;
        Description = project.Description;
        CreatedAt = project.CreatedAt;
        
        Tasks = project.Tasks.Select(task => new TaskDto(task)).ToList();
    }
}