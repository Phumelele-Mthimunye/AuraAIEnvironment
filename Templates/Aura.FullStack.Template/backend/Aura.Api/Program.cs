using Aura.Application.Configuration;
using Aura.Infrastructure.Configuration;
using Aura.Api.Middleware;
using Aura.Application.Interfaces;
using Aura.Api.Services;
using Microsoft.Extensions.Hosting;

using Serilog;


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(
        "Logs/aura-log-.txt",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();


try
{
    Log.Information("Starting Aura API");


    var builder = WebApplication.CreateBuilder(args);


    builder.Host.UseSerilog();

    builder.Services.AddHttpContextAccessor();

    builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

    // Framework services
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    
    builder.Services.AddSwaggerGen(options =>
    {
        options.CustomSchemaIds(type => type.FullName);
    });

    // Application layers
    builder.Services.AddApplication();

    builder.Services.AddInfrastructure(
        builder.Configuration);

    var app = builder.Build();

    app.Use(async (context, next) =>
    {
        try
        {
            await next();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Unhandled pipeline exception");
            throw;
        }
    });


    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<ExceptionHandlingMiddleware>();

    app.UseSerilogRequestLogging();

    app.UseHttpsRedirection();

    app.UseAuthentication();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (HostAbortedException)
{
    // EF Core tooling stops the host intentionally.
}
catch (Exception ex)
{
    Log.Fatal(
        ex,
        "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}