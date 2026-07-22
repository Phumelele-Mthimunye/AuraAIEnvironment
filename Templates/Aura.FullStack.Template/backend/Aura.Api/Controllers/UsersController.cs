using Aura.Application.Users.Commands.CreateUser;
using Aura.Application.Users.Queries.GetUser;
using Aura.Application.Interfaces;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Aura.Api.Controllers;


[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ICurrentUserService _currentUser;


    public UsersController(
        IMediator mediator,
        ICurrentUserService currentUser)
    {
        _mediator = mediator;
        _currentUser = currentUser;
    }



    [HttpPost]
    public async Task<IActionResult> Create(
        CreateUserCommand command)
    {
        var result =
            await _mediator.Send(command);


        return Ok(result);
    }



    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(
        Guid id)
    {
        var result =
            await _mediator.Send(
                new GetUserQuery(id));


        if (result == null)
        {
            return NotFound();
        }


        return Ok(result);
    }



    [Authorize]
    [HttpGet("me")]
    public IActionResult Me()
    {
        return Ok(new
        {
            UserId = _currentUser.UserId,
            Email = _currentUser.Email,
            Authenticated =
                _currentUser.IsAuthenticated
        });
    }
}