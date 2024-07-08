using Microsoft.EntityFrameworkCore;
using TaskTrackr.Data;
using TaskTrackr.Dtos.Project;
using TaskTrackr.Interfaces;
using TaskTrackr.Models;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Repositories;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDbContext _context;

    public ProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Project>> GetAllAsync(QueryObject query)
    {
        var projects = _context.Project
            .Include(p => p.Tasks)
            .AsQueryable();
        
        // filtering
        if (!string.IsNullOrEmpty(query.Name))
            projects = projects.Where(p=>
                p.Name.ToLower().Contains(query.Name.ToLower()));
        
        // sorting
        projects = query.IsDescending ? 
            projects.OrderByDescending(p => p.Name) : 
            projects.OrderBy(p => p.Name);
        
        return await projects.
            Skip(query.ToSkip()).
            Take(query.PageSize).
            ToListAsync();
    }

    public async Task<Project?> GetByIdAsync(int id)
    {
        return await _context.Project
            .Include(p => p.Tasks)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Project> CreateAsync(CreateProjectDto projectDto)
    {
        var project = new Project(projectDto);
        
        await _context.AddAsync(project);
        await _context.SaveChangesAsync();

        return project;
    }

    public async Task<Project?> UpdateAsync(int id, UpdateProjectDto projectDto)
    {
        var project = await _context.Project
            .Include(u => u.Tasks)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (project == null)
            return null;

        project.Update(projectDto);
        await _context.SaveChangesAsync();

        return project;
    }

    public async Task<Project?> DeleteAsync(int id)
    {
        var project = await _context.Project
            .Include(p => p.Tasks)
            .FirstOrDefaultAsync(p => p.Id == id);
        if (project == null)
            return null;

        project.DeletedAt = DateTime.Now;
        await _context.SaveChangesAsync();

        return project;
    }

    public async Task<bool> Exists(int id)
    {
        return await _context.Project.AnyAsync(p => p.Id == id);
    }
}