using Aura.Domain.Common;

namespace Aura.Domain.Entities;

public class User : AuditableEntity
{
    public string Email { get; private set; } = string.Empty;

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string PasswordHash { get; private set; } = string.Empty;

    public ICollection<RefreshToken> RefreshTokens { get; private set; } = new List<RefreshToken>();

    private User()
    {
    }


    public User(
        string email,
        string firstName,
        string lastName,
        string passwordHash)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        PasswordHash = passwordHash;
    }


    public void UpdateDetails(
        string email,
        string firstName,
        string lastName)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;

        UpdateModifiedDate();
    }

    public void UpdatePassword(
    string passwordHash)
    {
    PasswordHash = passwordHash;

    UpdateModifiedDate();
    }
}