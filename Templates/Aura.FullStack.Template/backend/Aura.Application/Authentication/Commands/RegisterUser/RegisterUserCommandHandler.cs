using Aura.Application.Authentication.DTOs;
using Aura.Application.Authentication.Interfaces;
using Aura.Application.Interfaces;
using Aura.Domain.Entities;
using MediatR;

namespace Aura.Application.Authentication.Commands.RegisterUser;

public class RegisterUserCommandHandler
    : IRequestHandler<RegisterUserCommand, AuthResponseDto>
{
    private readonly IUsersAdapter _usersAdapter;
    private readonly IPasswordHasher _passwordHasher;
    private readonly ITokenService _tokenService;


    public RegisterUserCommandHandler(
        IUsersAdapter usersAdapter,
        IPasswordHasher passwordHasher,
        ITokenService tokenService)
    {
        _usersAdapter = usersAdapter;
        _passwordHasher = passwordHasher;
        _tokenService = tokenService;
    }


    public async Task<AuthResponseDto> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken)
    {
        var userExists = await _usersAdapter
            .ExistsByEmailAsync(
                request.Email,
                cancellationToken);

        if (userExists)
        {
            throw new Exception("Email already registered");
        }

        var passwordHash =
            _passwordHasher.Hash(request.Password);


        var user = new User(
            request.Email,
            request.FirstName,
            request.LastName,
            passwordHash);


        var refreshToken =
            _tokenService.GenerateRefreshToken();


        var refreshTokenEntity =
            new RefreshToken(
                user.Id,
                refreshToken,
                DateTime.UtcNow.AddDays(7));


        user.RefreshTokens.Add(
            refreshTokenEntity);


        var createdUser =
            await _usersAdapter.CreateAsync(
                user,
                cancellationToken);


        var accessToken =
            _tokenService.GenerateAccessToken(
                createdUser.Id,
                createdUser.Email);


        return new AuthResponseDto
        {
            UserId = createdUser.Id,
            Email = createdUser.Email,
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };
    }
}