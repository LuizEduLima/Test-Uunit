using Microsoft.EntityFrameworkCore;
using ProjetoTests.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTests.Domain.Context
{
   public class MyContext:DbContext
    {
        public MyContext()
        {

        }
        public DbSet<Produto>Produtos { get; set; }

        public MyContext(DbContextOptions<MyContext>options):base(options)
        {

        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
           
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBTests;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.Id);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);

        }
    }

}
