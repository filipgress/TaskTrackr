namespace TaskTrackr.Models.Helpers;

public class UserQuery : QueryObject
{
    public string? Email { get; set; }
    public SortUserBy SortBy { get; set; } = SortUserBy.Name;
}