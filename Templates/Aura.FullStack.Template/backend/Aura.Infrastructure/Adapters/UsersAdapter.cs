using Aura.Application.Interfaces;
using Aura.Domain.Entities;
using Aura.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Aura.Infrastructure.Adapters;

public class UsersAdapter : IUsersAdapter
{
    private readonly AuraDbContext _context;


    public UsersAdapter(
        AuraDbContext context)
    {
        _context = context;
    }


    public async Task<User> CreateAsync(
        User user,
        CancellationToken cancellationToken)
    {
        await _context.Users.AddAsync(
            user,
            cancellationToken);


        await _context.SaveChangesAsync(
            cancellationToken);


        return user;
    }


    public async Task<User?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken)
    {
        return await _context.Users
            .FirstOrDefaultAsync(
                x => x.Id == id,
                cancellationToken);
    }

    public async Task SaveChangesAsync(
        CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(
        cancellationToken);
    }

    public async Task<bool> ExistsByEmailAsync(
        string email,
        CancellationToken cancellationToken)
    {
        return await _context.Users
            .AnyAsync(
                x => x.Email == email,
                cancellationToken);
    }
}