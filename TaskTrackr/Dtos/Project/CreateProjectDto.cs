
using System.ComponentModel.DataAnnotations;

namespace TaskTrackr.Dtos.Project;

public class CreateProjectDto
{
    [MinLength(5)] [MaxLength(50)]
    public required string Name { get; set; }
    
    [MaxLength(500)]
    public required string Description { get; set; }
}