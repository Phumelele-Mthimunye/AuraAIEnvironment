using Aura.Application.Interfaces;
using Aura.Infrastructure.Adapters;
using Aura.Infrastructure.Database;
using Aura.Application.Authentication.Interfaces;
using Aura.Infrastructure.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Aura.Infrastructure.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AuraDbContext>(
            options =>
                options.UseNpgsql(
                    configuration.GetConnectionString(
                        "DefaultConnection"),
                    npgsql =>
                        npgsql.MigrationsAssembly(
                            typeof(AuraDbContext).Assembly.FullName)));

        services.AddScoped<IUsersAdapter, UsersAdapter>();
        
        services.AddScoped<IPasswordHasher, PasswordHasher>();

        services.AddScoped<ITokenService, TokenService>();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                var jwtSettings = configuration.GetSection("Jwt");

                options.TokenValidationParameters =
                new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtSettings["Issuer"],

                    ValidateAudience = true,
                    ValidAudience = jwtSettings["Audience"],

                    ValidateLifetime = true,

                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey =
                        new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(
                                jwtSettings["Secret"]!))
                };
            });

        return services;
    }
}