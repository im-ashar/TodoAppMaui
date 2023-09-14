using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoAppMaui.Shared;

namespace TodoAppMaui.Database
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoAppMaui;");
        }
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}