using System.Security.Claims;
using Aura.Application.Interfaces;

namespace Aura.Api.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;


    public CurrentUserService(
        IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }


    public Guid? UserId
    {
        get
        {
            var id = _httpContextAccessor
                .HttpContext?
                .User?
                .FindFirstValue(
                    ClaimTypes.NameIdentifier);

            return Guid.TryParse(
                id,
                out var guid)
                ? guid
                : null;
        }
    }


    public string? Email =>
        _httpContextAccessor
            .HttpContext?
            .User?
            .FindFirstValue(
                ClaimTypes.Email);


    public bool IsAuthenticated =>
        _httpContextAccessor
            .HttpContext?
            .User?
            .Identity?
            .IsAuthenticated
            ?? false;
}