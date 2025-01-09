﻿// <auto-generated />
using System;
using Final_RestaurantWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_RestaurantWebApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_RestaurantWebApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Appetizer"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Entree"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Side Dish"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Dessert"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Beverage"
                        });
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            Name = "Beef"
                        },
                        new
                        {
                            IngredientId = 2,
                            Name = "Pork"
                        },
                        new
                        {
                            IngredientId = 3,
                            Name = "Chicken"
                        },
                        new
                        {
                            IngredientId = 4,
                            Name = "Lettuce"
                        },
                        new
                        {
                            IngredientId = 5,
                            Name = "Carrot"
                        },
                        new
                        {
                            IngredientId = 6,
                            Name = "Tomato"
                        },
                        new
                        {
                            IngredientId = 7,
                            Name = "Cheese"
                        },
                        new
                        {
                            IngredientId = 8,
                            Name = "Bacon"
                        },
                        new
                        {
                            IngredientId = 9,
                            Name = "Onion"
                        },
                        new
                        {
                            IngredientId = 10,
                            Name = "Garlic"
                        },
                        new
                        {
                            IngredientId = 11,
                            Name = "Cucumber"
                        },
                        new
                        {
                            IngredientId = 12,
                            Name = "Croutons"
                        },
                        new
                        {
                            IngredientId = 13,
                            Name = "Egg"
                        },
                        new
                        {
                            IngredientId = 14,
                            Name = "Mayo"
                        },
                        new
                        {
                            IngredientId = 15,
                            Name = "Avocado"
                        },
                        new
                        {
                            IngredientId = 16,
                            Name = "Rice"
                        },
                        new
                        {
                            IngredientId = 17,
                            Name = "Soy Sauce"
                        },
                        new
                        {
                            IngredientId = 18,
                            Name = "Taco Shell"
                        },
                        new
                        {
                            IngredientId = 19,
                            Name = "Lime"
                        },
                        new
                        {
                            IngredientId = 20,
                            Name = "Chicken Breast"
                        },
                        new
                        {
                            IngredientId = 21,
                            Name = "Salsa"
                        });
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            Description = "Juicy beef patty with cheddar cheese, lettuce, tomato, and bacon on a toasted bun.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Cheeseburger",
                            Price = 12m,
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Description = "Soft corn tortillas with seasoned pulled pork, onions, cilantro, and salsa.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Pork Tacos",
                            Price = 10m,
                            Stock = 15
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Grilled chicken breast served on romaine lettuce with Caesar dressing and croutons.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Chicken Caesar Salad",
                            Price = 14m,
                            Stock = 10
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Stir-fried beef with vegetables like bell peppers, onions, and soy sauce, served with steamed rice.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Beef Stir Fry",
                            Price = 16m,
                            Stock = 12
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "Flour tortilla wrapped around seasoned chicken, rice, beans, and guacamole.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Chicken Burrito",
                            Price = 12m,
                            Stock = 20
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Description = "Sliced avocado with a poached egg on toasted sourdough bread, topped with a sprinkle of chili flakes.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Avocado Toast",
                            Price = 8m,
                            Stock = 18
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            Description = "A tart lemon filling with a fluffy meringue top, baked in a buttery pie crust.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Lemon Meringue Pie",
                            Price = 6m,
                            Stock = 8
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 5,
                            Description = "Tequila, lime juice, and triple sec served with a salted rim.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Classic Margarita",
                            Price = 7m,
                            Stock = 30
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            Description = "Ground beef with lettuce, tomato, cheese, and taco shell chips, topped with salsa and sour cream.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Beef Taco Salad",
                            Price = 13m,
                            Stock = 25
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            Description = "Slow-cooked ribs coated in BBQ sauce, served with mashed potatoes and coleslaw.",
                            ImageUrl = "https://littlesunnykitchen.com/shredded-chicken-tacos/",
                            Name = "Pork Ribs",
                            Price = 20m,
                            Stock = 6
                        });
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.ProductIngredient", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("ProductIngredients");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 7
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 6
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 8
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 9
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 21
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 12
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 9
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 10
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 16
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 17
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 16
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 14
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 15
                        },
                        new
                        {
                            ProductId = 6,
                            IngredientId = 15
                        },
                        new
                        {
                            ProductId = 6,
                            IngredientId = 13
                        },
                        new
                        {
                            ProductId = 7,
                            IngredientId = 19
                        },
                        new
                        {
                            ProductId = 8,
                            IngredientId = 19
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 6
                        },
                        new
                        {
                            ProductId = 9,
                            IngredientId = 18
                        },
                        new
                        {
                            ProductId = 10,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 10,
                            IngredientId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Order", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.ApplicationUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.OrderItem", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_RestaurantWebApp.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Product", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.ProductIngredient", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.Ingredient", "Ingredient")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_RestaurantWebApp.Models.Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_RestaurantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Final_RestaurantWebApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.ApplicationUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Ingredient", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Final_RestaurantWebApp.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ProductIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
