using Microsoft.EntityFrameworkCore;
using ServodataTask.Entities.Models;

namespace ServodataTask.Entities.Context
{
    public class AdventureWorks2014Context : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public AdventureWorks2014Context(DbContextOptions<AdventureWorks2014Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}