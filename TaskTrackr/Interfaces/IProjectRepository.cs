using TaskTrackr.Dtos.Project;
using TaskTrackr.Models;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> GetAllAsync(QueryObject query);
    Task<Project?> GetByIdAsync(int id);
    Task<Project> CreateAsync(CreateProjectDto projectDto);
    Task<Project?> DeleteAsync(int id);
    Task<Project?> UpdateAsync(int id, UpdateProjectDto projectDto);
    Task<bool> Exists(int id);
}