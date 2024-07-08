using TaskTrackr.Models;

namespace TaskTrackr.Interfaces;

public interface ITokenService
{
    string CreateToken(User user, string role);
}