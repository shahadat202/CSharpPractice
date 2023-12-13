using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            //DESKTOP - N8A2ENF\SQLEXPRESS
            _connectionString = "Server=DESKTOP-N8A2ENF\\SQLEXPRESS;Database=CSharpB15;User Id=csharpb15;Password=12345; Trust Server Certificate = True;";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
