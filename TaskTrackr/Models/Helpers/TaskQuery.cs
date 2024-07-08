namespace TaskTrackr.Models.Helpers;

public class TaskQuery : QueryObject
{
    public TaskPriority? MaxPriority { get; set; }
    public TaskPriority? MinPriority { get; set; }
    
    public int? MaxDifficulty { get; set; }
    public int? MinDifficulty { get; set; }

    public bool IsCompleted { get; set; }
    
    public int? ProjectId { get; set; }
    public string? UserId { get; set; }

    public SortTaskBy SortBy { get; set; } = SortTaskBy.Name;
}