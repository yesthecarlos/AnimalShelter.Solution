using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Name = "Kerry", Species = "Cat", Age = 3, Gender = "Male" },
        new Animal { AnimalId = 2, Name = "Felix", Species = "Cat", Age = 15, Gender = "Male" },
        new Animal { AnimalId = 3, Name = "Sharona", Species = "Dog", Age = 15, Gender = "Female" },
        new Animal { AnimalId = 4, Name = "Frank", Species = "Dog", Age = 10, Gender = "Male" },
        new Animal { AnimalId = 5, Name = "Luda", Species = "Cat", Age = 15, Gender = "Male" },
        new Animal { AnimalId = 6, Name = "Cornelius", Species = "Cat", Age = 10, Gender = "Male" }
      );
  }
  }

  
}