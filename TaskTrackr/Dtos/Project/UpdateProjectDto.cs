using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Dtos.Project;

public class UpdateProjectDto
{
    [MinLength(5)] [MaxLength(50)]
    public string? Name { get; set; }
    
    [MaxLength(500)]
    public string? Description { get; set; }
}