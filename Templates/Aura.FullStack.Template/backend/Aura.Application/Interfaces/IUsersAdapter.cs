using Aura.Domain.Entities;

namespace Aura.Application.Interfaces;

/// <summary>
/// Defines infrastructure operations required by user workflows.
/// The service layer depends on this abstraction, not the database.
/// </summary>
public interface IUsersAdapter
{
    Task<User> CreateAsync(User user, CancellationToken cancellationToken);

    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task SaveChangesAsync(CancellationToken cancellationToken);

    Task<bool> ExistsByEmailAsync(
    string email,
    CancellationToken cancellationToken);
}