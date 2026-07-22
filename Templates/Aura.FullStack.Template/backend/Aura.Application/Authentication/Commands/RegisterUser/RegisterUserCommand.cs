using MediatR;
using Aura.Application.Authentication.DTOs;

namespace Aura.Application.Authentication.Commands.RegisterUser;

public record RegisterUserCommand(
    string Email,
    string Password,
    string FirstName,
    string LastName
) : IRequest<AuthResponseDto>;