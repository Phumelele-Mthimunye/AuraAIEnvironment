using Aura.Domain.Common;

namespace Aura.Domain.Entities;

public class RefreshToken : BaseEntity
{
    public Guid UserId { get; private set; }

    public string Token { get; private set; } = null!;

    public DateTime ExpiresAt { get; private set; }

    public DateTime? RevokedAt { get; private set; }

    public User User { get; private set; } = null!;

    public bool IsExpired =>
        DateTime.UtcNow >= ExpiresAt;


    public bool IsRevoked =>
        RevokedAt.HasValue;


    public bool IsActive =>
        !IsExpired && !IsRevoked;


    private RefreshToken()
    {
    }


    public RefreshToken(
        Guid userId,
        string token,
        DateTime expiresAt)
    {
        UserId = userId;
        Token = token;
        ExpiresAt = expiresAt;
    }


    public void Revoke()
    {
        RevokedAt = DateTime.UtcNow;
    }
}