using Aura.Application.Interfaces;
using Aura.Domain.Entities;
using MediatR;
using Aura.Application.Authentication.Interfaces;

namespace Aura.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler
    : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IUsersAdapter _usersAdapter;
    private readonly IPasswordHasher _passwordHasher;


    public CreateUserCommandHandler(
        IUsersAdapter usersAdapter,
        IPasswordHasher passwordHasher)
    {
        _usersAdapter = usersAdapter;
        _passwordHasher = passwordHasher;
    }


    public async Task<Guid> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken)
    {
        var passwordHash = _passwordHasher.Hash(
            request.Password);

        var user = new User(
            request.Email,
            request.FirstName,
            request.LastName,
            passwordHash);


        var createdUser =
            await _usersAdapter.CreateAsync(
                user,
                cancellationToken);


        return createdUser.Id;
    }
}