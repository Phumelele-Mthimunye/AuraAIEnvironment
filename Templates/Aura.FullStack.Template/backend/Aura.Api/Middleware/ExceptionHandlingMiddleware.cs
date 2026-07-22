using Aura.Api.Models;
using FluentValidation;
using Serilog;
using System.Net;
using System.Text.Json;

namespace Aura.Api.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(
        RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ValidationException ex)
        {
            Log.Error(ex, "Validation exception");

            await HandleValidationException(
                context,
                ex);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Unhandled exception");

            await HandleException(
                context,
                ex);
        }
    }

    private static async Task HandleValidationException(
        HttpContext context,
        ValidationException exception)
    {
        context.Response.StatusCode =
            (int)HttpStatusCode.BadRequest;

        context.Response.ContentType =
            "application/json";

        var response = new ApiErrorResponse
        {
            Message = "Validation failed",
            Errors = exception.Errors
                .Select(x => x.ErrorMessage)
        };

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(response));
    }

    private static async Task HandleException(
        HttpContext context,
        Exception exception)
    {
        context.Response.StatusCode =
            (int)HttpStatusCode.InternalServerError;

        context.Response.ContentType =
            "application/json";

        var response = new
        {
            Message = exception.Message,
            Exception = exception.GetType().FullName,
            StackTrace = exception.StackTrace
        };

        await context.Response.WriteAsync(
            JsonSerializer.Serialize(
                response,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
    }
}