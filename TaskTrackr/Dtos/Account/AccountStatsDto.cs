using TaskTrackr.Services;

namespace TaskTrackr.Dtos.Account;

public class AccountStatsDto
{
    public int TotalTasks { get; set; }
    public int OverdueTasks { get; set; }
    public int CompletedTasks { get; set; }
    
    public double? AvgDifficulty { get; set; }
    public TimeSpan? AvgCompletionTime { get; set; }

    public AccountStatsDto(List<Models.Task> tasks)
    {
        TotalTasks = tasks.Count;
        OverdueTasks = StatisticsService.GetOverdueTaskCount(tasks);
        CompletedTasks = StatisticsService.GetCompletedTaskCount(tasks);
        
        AvgDifficulty = StatisticsService.GetAvgTaskDifficulty(tasks);
        AvgCompletionTime = StatisticsService.GetAvgCompletionTime(tasks);
    }
}