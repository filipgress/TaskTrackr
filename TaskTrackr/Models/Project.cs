using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Models;

public class Project
{
    public int Id { get; set; }

    [MaxLength(50)] public required string Name { get; set; }
    [MaxLength(500)] public required string Description { get; set; }

    public virtual ICollection<User> Users { get; set; } = [];
    public virtual ICollection<Task> Tasks { get; set; } = [];
}