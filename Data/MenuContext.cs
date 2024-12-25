using System;
using System.Collections.Generic;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Data;

public partial class MenuContext : DbContext
{
    public MenuContext()
    {
    }

    public MenuContext(DbContextOptions<MenuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DishsIngredient> DishsIngredients { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Amira;Initial Catalog=Menu;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(entity =>
        {
            entity.Property(e => e.ImageUrl).IsFixedLength();
            entity.Property(e => e.Name).IsFixedLength();
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.Property(e => e.Name).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
