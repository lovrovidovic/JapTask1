﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Recipes.Api.Data;

namespace Recipes.Api.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("services.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Salata"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Palacinke"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Waffle"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Hamburger"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Sendvic"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Torta"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Kolac"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Pita"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2018, 8, 6, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Sladoled"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Jela s rostilja"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2000, 4, 4, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Name = "Peciva"
                        });
                });

            modelBuilder.Entity("services.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("NormativePrice")
                        .HasColumnType("real");

                    b.Property<float>("NormativeQuantity")
                        .HasColumnType("real");

                    b.Property<int>("NormativeUnit")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brasno",
                            NormativePrice = 18.4f,
                            NormativeQuantity = 25f,
                            NormativeUnit = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mlijeko",
                            NormativePrice = 10.3f,
                            NormativeQuantity = 15f,
                            NormativeUnit = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "Secer",
                            NormativePrice = 5.5f,
                            NormativeQuantity = 250f,
                            NormativeUnit = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Maslac",
                            NormativePrice = 20f,
                            NormativeQuantity = 2f,
                            NormativeUnit = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mlijecna cokolada",
                            NormativePrice = 10f,
                            NormativeQuantity = 500f,
                            NormativeUnit = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Crna cokolada",
                            NormativePrice = 17.4f,
                            NormativeQuantity = 500f,
                            NormativeUnit = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Jaje",
                            NormativePrice = 3.6f,
                            NormativeQuantity = 10f,
                            NormativeUnit = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Voda",
                            NormativePrice = 1.2f,
                            NormativeQuantity = 1f,
                            NormativeUnit = 3
                        });
                });

            modelBuilder.Entity("services.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Fini cokoladni kolac.",
                            Name = "Cokoladni kolac",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Osvjezavajuci bijeli kolac",
                            Name = "Bijeli kolac",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac koji ima kokos",
                            Name = "Rafaelo",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac koji ima ferrero roche (samo u imenu)",
                            Name = "Ferrero",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac napravljen s jabukama",
                            Name = "Kolac s jagodama",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac napravljen s jagodama",
                            Name = "Kolac s jabukama",
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac za djecu",
                            Name = "Kinder",
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Dva kolaca u jednom",
                            Name = "Twix",
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 7,
                            CreatedAt = new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac s ljesnacima i karamelom",
                            Name = "Snickers",
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 7,
                            CreatedAt = new DateTime(1999, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Kolac s orahom",
                            Name = "Orah",
                            UserId = 2
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 7,
                            CreatedAt = new DateTime(1998, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Ovaj kolac sluzi za pokazivanje funkcionalnosti load more buttona",
                            Name = "Specijalitet kuce",
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified),
                            Description = "Dummy Description",
                            Name = "Dummy recept",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("services.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("integer");

                    b.Property<int>("IngredientId")
                        .HasColumnType("integer");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Unit")
                        .HasColumnType("integer");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 1,
                            Quantity = 2f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 2,
                            Quantity = 2.5f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 1,
                            IngredientId = 3,
                            Quantity = 500f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 4,
                            Quantity = 20f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 2,
                            IngredientId = 8,
                            Quantity = 350f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 7,
                            Quantity = 4f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 5,
                            Quantity = 400f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 3,
                            IngredientId = 6,
                            Quantity = 1.7f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 4,
                            IngredientId = 1,
                            Quantity = 275f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 8,
                            Quantity = 1.1f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 4,
                            Quantity = 125f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 5,
                            IngredientId = 7,
                            Quantity = 1f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 6,
                            IngredientId = 2,
                            Quantity = 50f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 6,
                            IngredientId = 5,
                            Quantity = 15f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 7,
                            IngredientId = 6,
                            Quantity = 3.2f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 7,
                            IngredientId = 4,
                            Quantity = 80f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 8,
                            IngredientId = 2,
                            Quantity = 1f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 8,
                            IngredientId = 7,
                            Quantity = 3f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 2,
                            Quantity = 2f,
                            Unit = 3
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 3,
                            Quantity = 1.9f,
                            Unit = 0
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 4,
                            Quantity = 20f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 9,
                            IngredientId = 8,
                            Quantity = 70f,
                            Unit = 2
                        },
                        new
                        {
                            RecipeId = 10,
                            IngredientId = 1,
                            Quantity = 5f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 10,
                            IngredientId = 7,
                            Quantity = 2f,
                            Unit = 4
                        },
                        new
                        {
                            RecipeId = 11,
                            IngredientId = 5,
                            Quantity = 100f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 11,
                            IngredientId = 4,
                            Quantity = 740f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 12,
                            IngredientId = 5,
                            Quantity = 100f,
                            Unit = 1
                        },
                        new
                        {
                            RecipeId = 12,
                            IngredientId = 4,
                            Quantity = 740f,
                            Unit = 1
                        });
                });

            modelBuilder.Entity("services.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "123",
                            Username = "user"
                        },
                        new
                        {
                            Id = 2,
                            Password = "sifra",
                            Username = "Mark"
                        },
                        new
                        {
                            Id = 3,
                            Password = "lozinka",
                            Username = "John"
                        });
                });

            modelBuilder.Entity("services.Models.Recipe", b =>
                {
                    b.HasOne("services.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("services.Models.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("services.Models.RecipeIngredient", b =>
                {
                    b.HasOne("services.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredient")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("services.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredient")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("services.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("services.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredient");
                });

            modelBuilder.Entity("services.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredient");
                });

            modelBuilder.Entity("services.Models.User", b =>
                {
                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
