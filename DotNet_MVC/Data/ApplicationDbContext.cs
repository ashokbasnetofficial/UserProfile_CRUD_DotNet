using Dotnet_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Mvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options)
        {
                
        }
        public DbSet<UserProfile> UserProfile { get; set; }
    }
}
//Add-Migration InitialPersistedGrantDbMigration -c ApplicationDbContext -o Data/Migrations