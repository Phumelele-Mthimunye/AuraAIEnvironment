using MediatR;

namespace Aura.Application.Users.Commands.CreateUser;

public record CreateUserCommand(
    string Email,
    string Password,
    string FirstName,
    string LastName
) : IRequest<Guid>;