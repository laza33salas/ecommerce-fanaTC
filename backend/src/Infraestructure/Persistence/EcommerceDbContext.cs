using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Persistence;

public class EcommerceDbContext : IdentityDbContext<Usuario>
{
   public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
   {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        //Relaciones 
        builder.Entity<Category>()
            .HasMany(p => p.Products) 
            .WithOne(r => r.Category)
            .HasForeignKey(r => r.CategoriaId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

         builder.Entity<Product>()
            .HasMany(p => p. Reviews)
            .WithOne(r => r.Product)
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

         builder.Entity<Product>()
            .HasMany(p => p. Images)
            .WithOne(r => r.Product)
            .HasForeignKey(r => r.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

         builder.Entity<ShoppingCart>()
            .HasMany(p => p. ShoppingCartItems)
            .WithOne(r => r. ShoppingCart)
            .HasForeignKey(r => r. ShoppingCartId)
            .OnDelete(DeleteBehavior.Cascade);



        //Restricciones de longitud para Identity
        builder.Entity<Usuario>().Property(x => x.Id).HasMaxLength(36);
        builder.Entity<Usuario>().Property(x => x.NormalizedUserName).HasMaxLength(90);
        builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(36);
        builder.Entity<IdentityRole>().Property(x => x.NormalizedName).HasMaxLength(90);
    }

   public DbSet<Product>? Products { get; set; }
   public DbSet<Category>? Categories { get; set; }
   public DbSet<Image>? Images { get; set; }
   public DbSet<Adress>? Adresses { get; set; }
   public DbSet<Order>? Orders { get; set; }
   public DbSet<OrderItems>? OrderItems { get; set; }
   public DbSet<Review>? Reviews { get; set; }
   public DbSet<ShoppingCart>? ShoppingCarts { get; set; }
   public DbSet<ShoppingCartItem>? ShoppingCartItems { get; set; }
   public DbSet<Country>? Countries { get; set; }
   public DbSet<OrderAdress>? OrderAdresses { get; set; }
}