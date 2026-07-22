using Aura.Api.Common.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Aura.Api.Controllers;

[ApiController]
public abstract class BaseApiController : ControllerBase
{

    protected IActionResult Success<T>(
        T data,
        string message = "")
    {
        return Ok(
            ApiResponse<T>.SuccessResponse(
                data,
                message));
    }


    protected IActionResult Failure(
        IEnumerable<string> errors,
        string message = "")
    {
        return BadRequest(
            ApiResponse<object>.FailureResponse(
                errors,
                message));
    }
}