namespace Aura.Application.Models.Responses;

/// <summary>
/// Data returned from the API.
/// Database entities should never be exposed directly.
/// </summary>
public class UserResponse
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}