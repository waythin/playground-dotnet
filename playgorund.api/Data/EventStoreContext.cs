using System;
using Microsoft.EntityFrameworkCore;
using playgorund.api.Entity;


namespace playgorund.api.Data;

public class EventStoreContext(DbContextOptions<EventStoreContext> options) : DbContext(options)
{
    // table names 
   public DbSet<User> Users => Set<User>();
   public DbSet<Role> Roles => Set<Role>();

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Role>().HasData(
              new { ID = 1, Name = "Super Admin", Description = "Super Admin Role", CreatedAt = DateTime.Now },
              new { ID = 2, Name = "Admin", Description = "Admin Role", CreatedAt = DateTime.Now }
       );
   }
          
}