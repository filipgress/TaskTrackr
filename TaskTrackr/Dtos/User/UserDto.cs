using TaskTrackr.Dtos.Project;

namespace TaskTrackr.Dtos.User;
public class UserDto
{
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public ICollection<ProjectDto> Projects { get; set; }

    public UserDto(Models.User user)
    {
        Id = user.Id;
        UserName = user.UserName!;
        Email = user.Email!;
        CreatedAt = user.CreatedAt;
        
        Projects = user.Projects.Select(project => new ProjectDto(project)).ToList();
    }
    
}