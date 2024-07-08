using Microsoft.EntityFrameworkCore;
using TaskTrackr.Data;
using TaskTrackr.Dtos.Task;
using TaskTrackr.Interfaces;
using TaskTrackr.Models.Helpers;
using Task = TaskTrackr.Models.Task;

namespace TaskTrackr.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly ApplicationDbContext _context;

    public TaskRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Task>> GetAllAsync(TaskQuery query)
    {
        var tasks = _context.Task.AsQueryable();

        if (!string.IsNullOrEmpty(query.Name))
            tasks = tasks.Where(t=>
                t.Name.ToLower().Contains(query.Name.ToLower()));

        // filtering 
        if (query.MaxPriority != null)
            tasks = tasks.Where(t =>
                t.Priority <= query.MaxPriority);
            
        if (query.MinPriority != null)
            tasks = tasks.Where(t =>
                t.Priority >= query.MinPriority);
        
        if (query.MaxDifficulty != null)
            tasks = tasks.Where(t =>
                t.Difficulty <= query.MaxDifficulty);
            
        if (query.MinDifficulty != null)
            tasks = tasks.Where(t =>
                t.Difficulty >= query.MinDifficulty);
        
        if (query.IsCompleted)
            tasks = tasks.Where(t =>
                t.CompletedAt != null);
                
        if (query.ProjectId != null)
            tasks = tasks.Where(t =>
                t.ProjectId == query.ProjectId);
        
        if (query.UserId != null)
            tasks = tasks.Where(t =>
                t.UserId == query.UserId);
        
        // sorting
        tasks = query.SortBy switch
        {
            SortTaskBy.Name => query.IsDescending ? tasks.OrderByDescending(t => t.Name) : tasks.OrderBy(t => t.Name),
            SortTaskBy.Priority => query.IsDescending
                ? tasks.OrderByDescending(t => t.Priority)
                : tasks.OrderBy(t => t.Priority),
            SortTaskBy.Difficulty => query.IsDescending
                ? tasks.OrderByDescending(t => t.Difficulty)
                : tasks.OrderBy(t => t.Difficulty),
            SortTaskBy.DueDate => query.IsDescending
                ? tasks.OrderByDescending(t => t.DueDate)
                : tasks.OrderBy(t => t.DueDate),
            SortTaskBy.CompletedAt => query.IsDescending
                ? tasks.OrderByDescending(t => t.CompletedAt)
                : tasks.OrderBy(t => t.CompletedAt),
            SortTaskBy.CreatedAt => query.IsDescending
                ? tasks.OrderByDescending(t => t.CreatedAt)
                : tasks.OrderBy(t => t.CreatedAt),
            _ => tasks 
        };

        return await tasks.
            Skip(query.ToSkip()).
            Take(query.PageSize).
            ToListAsync();
    }

    public async Task<Task?> GetByIdAsync(int id)
    {
        return await _context.Task.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<List<Task>> GetByUserIdAsync(string userId)
    {
        var tasks = _context.Task.AsQueryable();
        var userTasks = tasks.Where(t => t.UserId == userId);
        
        return await userTasks.ToListAsync();
    }

    public async Task<Task> CreateAsync(CreateTaskDto taskDto, int projectId)
    {
        var task = new Task(taskDto, projectId);
        
        await _context.AddAsync(task);
        await _context.SaveChangesAsync();

        return task;
    }

    public async Task<Task?> UpdateAsync(int id, UpdateTaskDto taskDto)
    {
        var task = await _context.Task
            .FirstOrDefaultAsync(x => x.Id == id);
        if (task == null)
            return null;

        task.Update(taskDto);
        await _context.SaveChangesAsync();

        return task;
    }

    public async Task<Task?> DeleteAsync(int id)
    {
        var task = await _context.Task
            .FirstOrDefaultAsync(x => x.Id == id);
        if (task == null)
            return null;
        
        task.DeletedAt = DateTime.Now;
        await _context.SaveChangesAsync();

        return task;
    }
}