using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Aura.Application.Authentication.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Aura.Infrastructure.Authentication;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;


    public TokenService(
        IConfiguration configuration)
    {
        _configuration = configuration;
    }


    public string GenerateAccessToken(
        Guid userId,
        string email)
    {
        var jwtSettings =
            _configuration.GetSection("Jwt");


        var key =
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    jwtSettings["Secret"]!));


        var credentials =
            new SigningCredentials(
                key,
                SecurityAlgorithms.HmacSha256);


        var claims = new[]
        {
            new Claim(
                ClaimTypes.NameIdentifier,
                userId.ToString()),

            new Claim(
                ClaimTypes.Email,
                email)
        };


        var token =
            new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires:
                    DateTime.UtcNow.AddMinutes(
                        int.Parse(
                            jwtSettings["AccessTokenExpirationMinutes"]!)),
                signingCredentials:
                    credentials);


        return new JwtSecurityTokenHandler()
            .WriteToken(token);
    }


    public string GenerateRefreshToken()
    {
        var randomBytes =
            new byte[64];


        using var rng =
            RandomNumberGenerator.Create();


        rng.GetBytes(randomBytes);


        return Convert.ToBase64String(
            randomBytes);
    }
}