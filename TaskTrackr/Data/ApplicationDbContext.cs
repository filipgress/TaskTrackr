using System.Text.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskTrackr.IO;
using TaskTrackr.Models;
using Task = TaskTrackr.Models.Task;

namespace TaskTrackr.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) {}
    
    public DbSet<User> User { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Task> Task { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        try
        {
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(
                File.ReadAllText("Data/UserSeedData.json"))!.ToList();
            
            var hasher = new PasswordHasher<IdentityUser>();
            users.ForEach(u => u.PasswordHash = hasher.HashPassword(null, "tajneHeslo_123"));

            var projects = JsonSerializer.Deserialize<IEnumerable<Project>>(
                File.ReadAllText("Data/ProjectSeedData.json"))!;

            var tasks = JsonSerializer.Deserialize<IEnumerable<Task>>(
                File.ReadAllText("Data/TaskSeedData.json"))!;

            var roles = JsonSerializer.Deserialize<IEnumerable<IdentityRole>>(
                File.ReadAllText("Data/RoleSeedData.json"))!;

            // many-to-many
            modelBuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithMany(p => p.Users)
                .UsingEntity(j => j.HasData([
                        new { UsersId = "1", ProjectsId = 1 },
                        new { UsersId = "1", ProjectsId = 2 },
                        new { UsersId = "2", ProjectsId = 3 },
                        new { UsersId = "2", ProjectsId = 4 },
                        new { UsersId = "2", ProjectsId = 5 },
                        new { UsersId = "3", ProjectsId = 5 },
                        new { UsersId = "4", ProjectsId = 1 },
                        new { UsersId = "4", ProjectsId = 2 },
                        new { UsersId = "5", ProjectsId = 2 },
                        new { UsersId = "5", ProjectsId = 3 }
                    ])
                );

            // one-to-many
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Tasks)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);

            // one-to-many
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tasks)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);

            // Seed data
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => u.DeletedAt == null)
                .HasData(users);

            modelBuilder.Entity<Project>()
                .HasQueryFilter(p => p.DeletedAt == null)
                .HasData(projects);

            modelBuilder.Entity<Task>()
                .HasQueryFilter(t => t.DeletedAt == null)
                .HasData(tasks);

            modelBuilder.Entity<IdentityRole>()
                .HasData(roles);
            
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                [
                new { RoleId = "1", UserId = "1" },
                new { RoleId = "2", UserId = "2" },
                new { RoleId = "2", UserId = "3" },
                new { RoleId = "2", UserId = "4" },
                new { RoleId = "2", UserId = "5" }
                ]
            );
        }
        catch (IOException ex)
        {
            Logger.DbCreationError("Unable to load seeding data from file.", ex);
        }
        catch (JsonException ex)
        {
            Logger.DbCreationError("Unable to deserialize data from JSON file. ", ex);
        }
        catch (Exception ex)
        {
            Logger.DbCreationError("Error DbContext while model creating.", ex);
        }
    }
}