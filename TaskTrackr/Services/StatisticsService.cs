namespace TaskTrackr.Services;
using Task = TaskTrackr.Models.Task;

public static class StatisticsService 
{
    public static int GetOverdueTaskCount(List<Task> tasks)
    {
        return tasks.Count(t => (
            !t.CompletedAt.HasValue && t.DueDate < DateTime.UtcNow
        ));
    }

    public static int GetCompletedTaskCount(List<Task> tasks)
    {
        return tasks.Count(t => t.CompletedAt.HasValue);
    }

    public static double? GetAvgTaskDifficulty(List<Task> tasks)
    {
        return tasks.Count > 0 ? tasks.Average(t => t.Difficulty) : null;
    }

    public static TimeSpan? GetAvgCompletionTime(List<Task> tasks)
    {
        var completedTasks = 
            tasks.Where(t => t.CompletedAt.HasValue).ToList();
        
        if (completedTasks.Count == 0) 
            return null;

        var totalCompletionTime = completedTasks
            .Select(t => t.CompletedAt!.Value - t.CreatedAt)
            .Aggregate((currSum, sum) => currSum + sum);
            
        return totalCompletionTime / completedTasks.Count;
    }
}