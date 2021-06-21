﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 3,
                            Gender = "Male",
                            Name = "Kerry",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 15,
                            Gender = "Male",
                            Name = "Felix",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 15,
                            Gender = "Female",
                            Name = "Sharona",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 10,
                            Gender = "Male",
                            Name = "Frank",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 15,
                            Gender = "Male",
                            Name = "Luda",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 10,
                            Gender = "Male",
                            Name = "Cornelius",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 10,
                            Gender = "Female",
                            Name = "Linda",
                            Species = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
