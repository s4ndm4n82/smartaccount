using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartAccount.Models;

namespace SmartAccount.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        // User Table
        public DbSet<TableUsers> TableUsers { get; set; }
        // Security Table
        public DbSet<TableUserSecurity> TableUsersSecurity { get; set; }
        // User Roles Table
        public DbSet<TableUserRoles> TableUserRoles { get; set; }
        // Customer Details Table
        public DbSet<TableCstDetails> TableCstDetails { get; set; }
        // Subscription Tier Table
        public DbSet<TableSubtiers> TableSubtiers { get; set; }
    }
}