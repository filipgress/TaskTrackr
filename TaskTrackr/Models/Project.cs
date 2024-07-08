using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaskTrackr.Dtos.Project;

namespace TaskTrackr.Models;

public class Project
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)] public string Name { get; set; }
    [MaxLength(500)] public string Description { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }
    public virtual ICollection<User> Users { get; set; } = [];
    public virtual ICollection<Task> Tasks { get; set; } = [];

    public Project() {}
    public Project(CreateProjectDto projectDto)
    {
        Name = projectDto.Name;
        Description= projectDto.Description;
    }

    public void Update(UpdateProjectDto projectDto)
    {
        if (projectDto.Name != null)
            Name = projectDto.Name;
        
        if (projectDto.Description != null)
            Description = projectDto.Description;
    }
}