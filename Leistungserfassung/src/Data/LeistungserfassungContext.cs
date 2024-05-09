using Leistungserfassung.Models;
using Microsoft.EntityFrameworkCore; // For DbContext and related classes
using Microsoft.Extensions.Configuration; // For configuration
using Npgsql.EntityFrameworkCore.PostgreSQL; // For UseNpgsql

namespace Leistungserfassung.Data;

// DbContext comes from EntityFramework

public class LeistungserfassungContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    public DbSet<Products> Products { get; set; } = null!;

    // for Oracle use this: 
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
        // var config = new ConfigurationBuilder()
        //     .AddUserSecrets<Program>()
        //     .Build();
    //     optionsBuilder.UseSqlServer(config["ConnectionString"]);
    // }
    
    // this for Postgres:
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            // connectionString secret in secrets.json => ignored by git
            optionsBuilder.UseNpgsql(config["ConnectionString"]);
        }
    }
}