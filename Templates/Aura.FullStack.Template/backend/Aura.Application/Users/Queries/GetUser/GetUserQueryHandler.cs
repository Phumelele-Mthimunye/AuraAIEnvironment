using Aura.Application.Interfaces;
using Aura.Application.Users.DTOs;
using MediatR;

namespace Aura.Application.Users.Queries.GetUser;


public class GetUserQueryHandler 
    : IRequestHandler<GetUserQuery, UserDto?>
{
    private readonly IUsersAdapter _usersAdapter;


    public GetUserQueryHandler(
        IUsersAdapter usersAdapter)
    {
        _usersAdapter = usersAdapter;
    }


    public async Task<UserDto?> Handle(
        GetUserQuery request,
        CancellationToken cancellationToken)
    {
        var user = await _usersAdapter.GetByIdAsync(
            request.Id,
            cancellationToken);


        if (user == null)
        {
            return null;
        }


        return new UserDto
        {
            Id = user.Id,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            CreatedDate = user.CreatedDate
        };
    }
}