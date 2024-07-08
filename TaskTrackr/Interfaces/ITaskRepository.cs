using TaskTrackr.Dtos.Task;
using TaskTrackr.Models.Helpers;
using Task = TaskTrackr.Models.Task;

namespace TaskTrackr.Interfaces;

public interface ITaskRepository
{
    Task<List<Task>> GetAllAsync(TaskQuery query);
    Task<Task?> GetByIdAsync(int id);
    Task<List<Task>> GetByUserIdAsync(string userId);
    
    Task<Task> CreateAsync(CreateTaskDto taskDto, int projectId);
    Task<Task?> DeleteAsync(int id);
    Task<Task?> UpdateAsync(int id, UpdateTaskDto taskDto);
}