namespace Aura.Application.Models.Requests;

/// <summary>
/// Data required to create a new user.
/// API request models should not expose database entities.
/// </summary>
public class CreateUserRequest
{
    public string Email { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}