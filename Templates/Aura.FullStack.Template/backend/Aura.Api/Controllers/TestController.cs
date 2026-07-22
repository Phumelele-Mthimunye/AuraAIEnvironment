using Aura.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aura.Api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly ICurrentUserService _currentUser;


    public TestController(
        ICurrentUserService currentUser)
    {
        _currentUser = currentUser;
    }


    [Authorize]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            authenticated = _currentUser.IsAuthenticated,
            userId = _currentUser.UserId,
            email = _currentUser.Email
        });
    }
}