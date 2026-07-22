using Aura.Application.Users.DTOs;
using MediatR;

namespace Aura.Application.Users.Queries.GetUser;

public record GetUserQuery(
    Guid Id) : IRequest<UserDto?>;