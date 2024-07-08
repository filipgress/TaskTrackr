using Microsoft.EntityFrameworkCore;
using TaskTrackr.Data;
using TaskTrackr.Dtos.User;
using TaskTrackr.Interfaces;
using TaskTrackr.Models;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllAsync(UserQuery query)
    {
        var users = _context.User
            .Include(u => u.Projects)
            .AsQueryable();

        // filtering
        if (!string.IsNullOrEmpty(query.Name))
            users = users.Where(u => 
                u.UserName.ToLower().Contains(query.Name.ToLower()));
        
        if (!string.IsNullOrEmpty(query.Email))
            users = users.Where(t=>
                t.Email.ToLower().Contains(query.Email.ToLower()));
        
        // sorting
        users = query.SortBy switch
        {
            SortUserBy.Name => query.IsDescending
                ? users.OrderByDescending(u => u.UserName)
                : users.OrderBy(u => u.UserName),
            SortUserBy.Email => query.IsDescending
                ? users.OrderByDescending(u => u.Email)
                : users.OrderBy(u => u.Email),
            _ => users
        };
        
        return await users.
            Skip(query.ToSkip()).
            Take(query.PageSize).
            ToListAsync();
    }

    public async Task<User?> GetByIdAsync(string id)
    {
        return await _context.User
            .Include(u => u.Projects)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    // public async Task<User> CreateAsync(CreateUserDto userDto)
    // {
    //     var user = new User(userDto);
    //     
    //     await _context.AddAsync(user);
    //     await _context.SaveChangesAsync();
    //
    //     return user;
    // }

    public async Task<User?> UpdateAsync(string id, UpdateUserDto userDto)
    {
        var user = await _context.User
            .Include(u => u.Projects)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
            return null;

        user.Update(userDto);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User?> DeleteAsync(string id)
    {
        var user = await _context.User
            .Include(u => u.Projects)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (user == null)
            return null;
        
        user.DeletedAt = DateTime.Now;
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<bool> Exists(string id)
    {
        return await _context.User.AnyAsync(u => u.Id == id);
    }
}