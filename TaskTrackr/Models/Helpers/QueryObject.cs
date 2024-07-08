namespace TaskTrackr.Models.Helpers;

public class QueryObject
{
    public string? Name { get; set; }
    public bool IsDescending { get; set; }
    
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    
    public int ToSkip() { return (Page - 1) * PageSize; }
}