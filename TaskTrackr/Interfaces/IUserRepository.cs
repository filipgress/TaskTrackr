using TaskTrackr.Dtos.User;
using TaskTrackr.Models;
using TaskTrackr.Models.Helpers;

namespace TaskTrackr.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync(UserQuery query);
    Task<User?> GetByIdAsync(string id);
    // Task<User> CreateAsync(CreateUserDto userDto);
    Task<User?> DeleteAsync(string id);
    Task<User?> UpdateAsync(string id, UpdateUserDto userDto);
    Task<bool> Exists(string id);
}