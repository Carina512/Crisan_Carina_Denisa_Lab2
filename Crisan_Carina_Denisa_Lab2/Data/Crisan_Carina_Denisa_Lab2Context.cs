using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_Carina_Denisa_Lab2.Models;

namespace Crisan_Carina_Denisa_Lab2.Data
{
    public class Crisan_Carina_Denisa_Lab2Context : DbContext
    {
        public Crisan_Carina_Denisa_Lab2Context (DbContextOptions<Crisan_Carina_Denisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Author>? Author { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Borrowing)
            .WithOne(e => e.Book)
                .HasForeignKey<Borrowing>("BookID");
        }
        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Member>? Member { get; set; }
        public DbSet<Crisan_Carina_Denisa_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
}
