using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APICliente.Models;

public partial class PruebaContext : DbContext
{
    public PruebaContext()
    {
    }

    public PruebaContext(DbContextOptions<PruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Beer> Beers { get; set; }
    public virtual DbSet<Brand> Brands { get; set; }





    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Brand>().ToTable("Brand", "PuntoDeVenta");
        modelBuilder.Entity<Beer>().ToTable("Beer", "PuntoDeVenta");

        /* */
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", "PuntoDeVenta");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
