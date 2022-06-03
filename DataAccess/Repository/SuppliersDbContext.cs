using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Repository.Entities;
using Microsoft.IdentityModel.Protocols;

namespace DataAccess.Repository
{
    public partial class SuppliersDbContext : DbContext
    {
        public SuppliersDbContext()
        {
        }

        public SuppliersDbContext(DbContextOptions<SuppliersDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=desktop-4g18nsn\\sqlexpress;Initial Catalog=SuppliersDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
