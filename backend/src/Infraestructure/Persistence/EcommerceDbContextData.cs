
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static Ecommerce.Application.Models.Authorization.Role;

namespace Ecommerce.Infraestructure.Persistence;

public class EcommerceDbContextData
{
    public static async Task LoadDataAsync(
     EcommerceDbContext context,
     UserManager<Usuario> usuarioManager,
     RoleManager<IdentityRole> roleManager,
     ILoggerFactory loggerFactory
    )
    {
        try
        {
            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole(ADMIN));
                await roleManager.CreateAsync(new IdentityRole(USER));
            }

            if (!usuarioManager.Users.Any())



            {
                var usuarioAdmin = new Usuario
                {
                  Nombre = "Super",
                  Apellido = "Usuario",
                  Email = "Prueba q no tengo que subir",
                  UserName = "Prueba",
                  AvatarUrl = "https://i.pravatar.cc/301"
                };
                
                await usuarioManager.CreateAsync(usuarioAdmin, "Admin123456789*");
                await usuarioManager.AddToRoleAsync(usuarioAdmin, ADMIN);


                 var usuario = new Usuario
                {
                  Nombre = "usuario",
                  Apellido = "Usuario1",
                  Email = "Prueba q no tengo que subir",
                  UserName = "Prueba",
                  AvatarUrl = "https://i.pravatar.cc/303"
                };
                
                await usuarioManager.CreateAsync(usuario, "Usuario123456789*");
                await usuarioManager.AddToRoleAsync(usuario, USER);
            }
       
            if(!context.Categories!.Any())
            {
                var categoryData = File.ReadAllText("../Infraestructure/Data/category.json");
                var categories = JsonConvert.DeserializeObject<List<Category>>(categoryData);
                await context.Categories!.AddRangeAsync(categories!);
                await context.SaveChangesAsync();
            }

            if(!context.Products!.Any())
            {
                var productData = File.ReadAllText("../Infraestructure/Data/product.json");
                var products = JsonConvert.DeserializeObject<List<Product>>(productData);
                await context.Products!.AddRangeAsync(products!);
                await context.SaveChangesAsync();
            }

            if (!context.Images!.Any())
            {
                var imageData = File.ReadAllText("../Infraestructure/Data/image.json");
                var images = JsonConvert.DeserializeObject<List<Image>>(imageData);
                await context.Images!.AddRangeAsync(images!);
                await context.SaveChangesAsync();
            }

            if (!context.Reviews!.Any())
            {
                var reviewData = File.ReadAllText("../Infraestructure/Data/review.json");
                var reviews = JsonConvert.DeserializeObject<List<Review>>(reviewData);
                await context.Reviews!.AddRangeAsync(reviews!);
                await context.SaveChangesAsync();
            }

            if (!context.Countries!.Any())
            {
                var countryData = File.ReadAllText("../Infraestructure/Data/country.json");
                var countries = JsonConvert.DeserializeObject<List<Country>>(countryData);
                await context.Countries!.AddRangeAsync(countries!);
                await context.SaveChangesAsync();
            }
       
        }
        catch (Exception e)
        {
            var logger = loggerFactory.CreateLogger<EcommerceDbContextData>();
            logger.LogError(e.Message);
        }
    }
}