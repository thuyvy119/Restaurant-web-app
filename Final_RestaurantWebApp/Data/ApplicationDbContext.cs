using Final_RestaurantWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Final_RestaurantWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProductIngredient> ProductIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define composite key and relationships for ProductIngredient
            // Define composite key and relationships for ProductIngredient
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);

            // Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizer" },
                new Category { CategoryId = 2, Name = "Entree" },
                new Category { CategoryId = 3, Name = "Side Dish" },
                new Category { CategoryId = 4, Name = "Dessert" },
                new Category { CategoryId = 5, Name = "Beverage" }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Beef" },
                new Ingredient { IngredientId = 2, Name = "Pork" },
                new Ingredient { IngredientId = 3, Name = "Chicken" },
                new Ingredient { IngredientId = 4, Name = "Lettuce" },
                new Ingredient { IngredientId = 5, Name = "Carrot" },
                new Ingredient { IngredientId = 6, Name = "Tomato" },
                new Ingredient { IngredientId = 7, Name = "Cheese" },
                new Ingredient { IngredientId = 8, Name = "Bacon" },
                new Ingredient { IngredientId = 9, Name = "Onion" },
                new Ingredient { IngredientId = 10, Name = "Garlic" },
                new Ingredient { IngredientId = 11, Name = "Cucumber" },
                new Ingredient { IngredientId = 12, Name = "Croutons" },
                new Ingredient { IngredientId = 13, Name = "Egg" },
                new Ingredient { IngredientId = 14, Name = "Mayo" },
                new Ingredient { IngredientId = 15, Name = "Avocado" },
                new Ingredient { IngredientId = 16, Name = "Rice" },
                new Ingredient { IngredientId = 17, Name = "Soy Sauce" },
                new Ingredient { IngredientId = 18, Name = "Taco Shell" },
                new Ingredient { IngredientId = 19, Name = "Lime" },
                new Ingredient { IngredientId = 20, Name = "Chicken Breast" },
                new Ingredient { IngredientId = 21, Name = "Salsa" }
            );

            // Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Cheeseburger",
                    Description = "Juicy beef patty with cheddar cheese, lettuce, tomato, and bacon on a toasted bun.",
                    Price = 12,
                    Stock = 20,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Pork Tacos",
                    Description = "Soft corn tortillas with seasoned pulled pork, onions, cilantro, and salsa.",
                    Price = 10,
                    Stock = 15,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Chicken Caesar Salad",
                    Description = "Grilled chicken breast served on romaine lettuce with Caesar dressing and croutons.",
                    Price = 14,
                    Stock = 10,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Beef Stir Fry",
                    Description = "Stir-fried beef with vegetables like bell peppers, onions, and soy sauce, served with steamed rice.",
                    Price = 16,
                    Stock = 12,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Chicken Burrito",
                    Description = "Flour tortilla wrapped around seasoned chicken, rice, beans, and guacamole.",
                    Price = 12,
                    Stock = 20,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Avocado Toast",
                    Description = "Sliced avocado with a poached egg on toasted sourdough bread, topped with a sprinkle of chili flakes.",
                    Price = 8,
                    Stock = 18,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Lemon Meringue Pie",
                    Description = "A tart lemon filling with a fluffy meringue top, baked in a buttery pie crust.",
                    Price = 6,
                    Stock = 8,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Classic Margarita",
                    Description = "Tequila, lime juice, and triple sec served with a salted rim.",
                    Price = 7,
                    Stock = 30,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Beef Taco Salad",
                    Description = "Ground beef with lettuce, tomato, cheese, and taco shell chips, topped with salsa and sour cream.",
                    Price = 13,
                    Stock = 25,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Pork Ribs",
                    Description = "Slow-cooked ribs coated in BBQ sauce, served with mashed potatoes and coleslaw.",
                    Price = 20,
                    Stock = 6,
                    CategoryId = 2
                }
            );

            // ProductIngredient relationships
            modelBuilder.Entity<ProductIngredient>().HasData(
                // Cheeseburger
                new ProductIngredient { ProductId = 1, IngredientId = 1 }, // Beef
                new ProductIngredient { ProductId = 1, IngredientId = 7 }, // Cheese
                new ProductIngredient { ProductId = 1, IngredientId = 4 }, // Lettuce
                new ProductIngredient { ProductId = 1, IngredientId = 6 }, // Tomato
                new ProductIngredient { ProductId = 1, IngredientId = 8 }, // Bacon

                // Pork Tacos
                new ProductIngredient { ProductId = 2, IngredientId = 2 }, // Pork
                new ProductIngredient { ProductId = 2, IngredientId = 9 }, // Onion
                new ProductIngredient { ProductId = 2, IngredientId = 21 }, // Salsa

                // Chicken Caesar Salad
                new ProductIngredient { ProductId = 3, IngredientId = 3 }, // Chicken
                new ProductIngredient { ProductId = 3, IngredientId = 4 }, // Lettuce
                new ProductIngredient { ProductId = 3, IngredientId = 12 }, // Croutons

                // Beef Stir Fry
                new ProductIngredient { ProductId = 4, IngredientId = 1 }, // Beef
                new ProductIngredient { ProductId = 4, IngredientId = 9 }, // Onion
                new ProductIngredient { ProductId = 4, IngredientId = 10 }, // Garlic
                new ProductIngredient { ProductId = 4, IngredientId = 16 }, // Rice
                new ProductIngredient { ProductId = 4, IngredientId = 17 }, // Soy Sauce

                // Chicken Burrito
                new ProductIngredient { ProductId = 5, IngredientId = 3 }, // Chicken
                new ProductIngredient { ProductId = 5, IngredientId = 16 }, // Rice
                new ProductIngredient { ProductId = 5, IngredientId = 14 }, // Mayo
                new ProductIngredient { ProductId = 5, IngredientId = 15 }, // Avocado

                // Avocado Toast
                new ProductIngredient { ProductId = 6, IngredientId = 15 }, // Avocado
                new ProductIngredient { ProductId = 6, IngredientId = 13 }, // Egg

                // Lemon Meringue Pie
                new ProductIngredient { ProductId = 7, IngredientId = 19 }, // Lime

                // Classic Margarita
                new ProductIngredient { ProductId = 8, IngredientId = 19 }, // Lime

                // Beef Taco Salad
                new ProductIngredient { ProductId = 9, IngredientId = 1 }, // Beef
                new ProductIngredient { ProductId = 9, IngredientId = 4 }, // Lettuce
                new ProductIngredient { ProductId = 9, IngredientId = 6 }, // Tomato
                new ProductIngredient { ProductId = 9, IngredientId = 18 }, // Taco Shell

                // Pork Ribs
                new ProductIngredient { ProductId = 10, IngredientId = 2 }, // Pork
                new ProductIngredient { ProductId = 10, IngredientId = 5 }  // Carrot
            );
        }
    }
}
