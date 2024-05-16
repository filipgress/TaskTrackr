using Microsoft.EntityFrameworkCore;
using TaskTrackr.Models;

namespace TaskTrackr.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) {}
    
    public DbSet<User> User { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Models.Task> Task { get; set; }
}