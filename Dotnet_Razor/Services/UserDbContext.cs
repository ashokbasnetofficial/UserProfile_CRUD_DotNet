using Dotnet_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Razor.Services
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext>options)
            :base(options) 
        { 

        }
        public DbSet<User> Users { get; set; }
    }
}
