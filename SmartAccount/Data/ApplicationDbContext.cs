using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
}