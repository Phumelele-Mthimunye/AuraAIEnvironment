using Aura.Application.Authentication.Commands.RegisterUser;
using Aura.Application.Authentication.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Aura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;


    public AuthController(
        IMediator mediator)
    {
        _mediator = mediator;
    }


    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDto>> Register(
        RegisterUserCommand command,
        CancellationToken cancellationToken)
    {
        var result =
            await _mediator.Send(
                command,
                cancellationToken);


        return Ok(result);
    }
}