using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TaskTrackr.Interfaces;
using TaskTrackr.Models;

namespace TaskTrackr.Services;

public class TokenService : ITokenService
{
    private readonly IConfiguration _config;
    private readonly SymmetricSecurityKey _key;

    public TokenService(IConfiguration config)
    {
        _config = config;
        _key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["JWT:SigningKey"]!)
        );
    }
    
    public string CreateToken(User user, string role)
    {
        var claims = new List<Claim>
        {
            new (JwtRegisteredClaimNames.Sub, user.Id),
            new (ClaimsIdentity.DefaultRoleClaimType, role)
            // new Claim(JwtRegisteredClaimNames.Email, user.Email),
            // new Claim(JwtRegisteredClaimNames.Name, user.UserName)
        };

        var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = creds,
            Issuer = _config["JWT:Issuer"],
            Audience = _config["JWT:Audience"]
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        
        return tokenHandler.WriteToken(token);
    }
}