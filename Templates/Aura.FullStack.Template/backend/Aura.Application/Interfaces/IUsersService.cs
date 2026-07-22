using Aura.Application.Models.Requests;
using Aura.Application.Models.Responses;

namespace Aura.Application.Interfaces;

/// <summary>
/// Defines user-related business operations.
/// </summary>
public interface IUsersService
{
    Task<UserResponse> CreateAsync(
        CreateUserRequest request,
        CancellationToken cancellationToken);

    Task<UserResponse?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken);
}