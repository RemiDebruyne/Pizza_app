﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza_API.Data;

#nullable disable

namespace Pizza_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pizza_API.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sauce de base.",
                            Name = "Sauce tomate"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fromage italien.",
                            Name = "Mozzarella"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Herbe aromatique.",
                            Name = "Basilic"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Salami épicé.",
                            Name = "Pepperoni"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Fromage de chèvre.",
                            Name = "Chèvre"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Fromage persillé.",
                            Name = "Bleu"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Fromage suisse.",
                            Name = "Emmental"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Viande de porc.",
                            Name = "Jambon"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Fruit tropical.",
                            Name = "Ananas"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Légume coloré.",
                            Name = "Poivrons"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Légume aromatique.",
                            Name = "Oignons"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Fongus comestible.",
                            Name = "Champignons"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Fruit méditerranéen.",
                            Name = "Olives"
                        });
                });

            modelBuilder.Entity("Pizza_API.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSpicy")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVege")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(37, 2)
                        .HasColumnType("decimal(37,2)");

                    b.HasKey("Id");

                    b.ToTable("pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Simple et classique avec de la sauce tomate, du fromage mozzarella et du basilic frais.",
                            ImagePath = "images/margherita.jpg",
                            IsSpicy = false,
                            IsVege = true,
                            Name = "Margherita",
                            Price = 8.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Garnie de tranches de pepperoni épicées sur une base de sauce tomate et mozzarella.",
                            ImagePath = "images/pepperoni.jpg",
                            IsSpicy = true,
                            IsVege = false,
                            Name = "Pepperoni",
                            Price = 10.99m
                        });
                });

            modelBuilder.Entity("Pizza_API.Models.PizzaIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("PizzaId");

                    b.ToTable("PizzaIngredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IngredientId = 1,
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 2,
                            IngredientId = 2,
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 3,
                            IngredientId = 1,
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 4,
                            IngredientId = 2,
                            PizzaId = 2
                        });
                });

            modelBuilder.Entity("Pizza_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("administrator_status");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "32 rue des potirons",
                            Email = "jeanbon@beurre.com",
                            FirstName = "Jean",
                            IsAdmin = false,
                            LastName = "Bon",
                            Password = "PAssword00++",
                            PhoneNumber = "01 02 03 04 05"
                        },
                        new
                        {
                            Id = 2,
                            Address = "54 rue de la Physique",
                            Email = "mariecurie@radium.com",
                            FirstName = "Marie",
                            IsAdmin = false,
                            LastName = "Curie",
                            Password = "SeCur3P@ss!",
                            PhoneNumber = "02 03 04 05 06"
                        },
                        new
                        {
                            Id = 3,
                            Address = "77 rue des Étoiles",
                            Email = "lucskywalker@force.com",
                            FirstName = "Luc",
                            IsAdmin = false,
                            LastName = "Skywalker",
                            Password = "Jed1Kn1ght!",
                            PhoneNumber = "03 04 05 06 07"
                        },
                        new
                        {
                            Id = 4,
                            Address = "88 chemin du Lapin Blanc",
                            Email = "alicewonder@wonderland.com",
                            FirstName = "Alice",
                            IsAdmin = false,
                            LastName = "Wonder",
                            Password = "W0nd3rL@nd!",
                            PhoneNumber = "04 05 06 07 08"
                        });
                });

            modelBuilder.Entity("Pizza_API.Models.PizzaIngredient", b =>
                {
                    b.HasOne("Pizza_API.Models.Ingredient", null)
                        .WithMany("PizzaIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizza_API.Models.Pizza", null)
                        .WithMany("PizzaIngredients")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pizza_API.Models.Ingredient", b =>
                {
                    b.Navigation("PizzaIngredients");
                });

            modelBuilder.Entity("Pizza_API.Models.Pizza", b =>
                {
                    b.Navigation("PizzaIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
