namespace Aura.Api.Models;

public class ApiErrorResponse
{
    public bool Success { get; set; } = false;

    public string Message { get; set; } = string.Empty;

    public IEnumerable<string> Errors { get; set; }
        = Array.Empty<string>();
}