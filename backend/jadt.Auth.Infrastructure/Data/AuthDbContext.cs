using jadt.Auth.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace jadt.Auth.Infrastructure.Data;

public class AuthDbContext(DbContextOptions<AuthDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}