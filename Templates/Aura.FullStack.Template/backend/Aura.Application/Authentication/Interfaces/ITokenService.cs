namespace Aura.Application.Authentication.Interfaces;

public interface ITokenService
{
    string GenerateAccessToken(
        Guid userId,
        string email);

    string GenerateRefreshToken();
}