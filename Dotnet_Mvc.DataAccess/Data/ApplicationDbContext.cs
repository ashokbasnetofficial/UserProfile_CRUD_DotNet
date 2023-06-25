using DotNet_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Mvc.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().HasData
                (
                new UserProfile { Id = 1, FullName = "Ashok Basnet", PhoneNumber = "9863614474", EmailAddress = "ashoknbasnetofficial@gmail.com", JobTitle = "Jonior Developer" },

                  new UserProfile { Id = 2, FullName = "Rajan Rijal", PhoneNumber = "9863614474", EmailAddress = "ashoknbasnetofficial@gmail.com", JobTitle = "Jonior Developer" },
                  new UserProfile { Id = 3, FullName = "Anu Thapa", PhoneNumber = "9863614474", EmailAddress = "ashoknbasnetofficial@gmail.com", JobTitle = "Techhincal Advistor" },
                      new UserProfile { Id = 4, FullName = "Rashika Bhattarai", PhoneNumber = "9863614474", EmailAddress = "rashikabhattarai59@gmail.com", JobTitle = "Student" },
                        new UserProfile { Id = 5, FullName = "Purna Bahadur Basnet", PhoneNumber = "9844666715", EmailAddress = "basnetpurna560@gmail.com", JobTitle = "Branch Manager" }
                );


            modelBuilder.Entity<Category>().HasData
                (
                    new Category { Id = 1, Name = "Samsung S22 Ultra", Description = "Samsung S22 Ultra 108mp camera", Price = 1000 }
                );

        }
    }
}
//Add-Migration InitialPersistedGrantDbMigration -c ApplicationDbContext -o Data/Migrations