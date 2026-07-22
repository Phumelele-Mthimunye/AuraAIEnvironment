using Aura.Domain.Entities;
using Aura.Application.Models.Responses;

namespace Aura.Application.Mappings;

/// <summary>
/// Provides conversion methods between database entities and API models.
/// Keeping mappings separate prevents business logic and transport concerns
/// from becoming mixed together.
/// </summary>
public static class UserMappingExtensions
{
    /// <summary>
    /// Converts a User entity into a response DTO.
    /// </summary>
    public static UserResponse ToResponse(this User user)
    {
        return new UserResponse
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }
}