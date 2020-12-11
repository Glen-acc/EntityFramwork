using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class CreateContext : DbContext
    {

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DbSet<AccountModerator> AccountModerators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebApp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().ToTable("WeatherForecast");
            modelBuilder.Entity<AccountModerator>().ToTable("AccountModerator");
        }
    }
}