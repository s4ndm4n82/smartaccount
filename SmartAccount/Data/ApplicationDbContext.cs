using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartAccount.Models;

namespace SmartAccount.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<TableUsers> TableUsers { get; set; }
        public DbSet<TableUserSecurity> TableUsersSecurity { get; set; }
        public DbSet<TableUserRoles> TableUserRoles { get; set; }
        public DbSet<TableCstDetails> TableCstDetails { get; set; }
        public DbSet<TableSubtiers> TableSubtiers { get; set; }
    }

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Create options builder using the configuration from the appsettings.json file
            DbContextOptionsBuilder<ApplicationDbContext> builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            // Create and return a new instance of the ApplicationDbContext
            return new ApplicationDbContext(builder.Options);
        }
    }
}