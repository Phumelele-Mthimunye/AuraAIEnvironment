namespace Aura.Application.Authentication.DTOs;

public class AuthResponseDto
{
    public Guid UserId { get; set; }

    public string Email { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;
}