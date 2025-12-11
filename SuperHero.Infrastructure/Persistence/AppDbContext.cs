using Microsoft.EntityFrameworkCore;
using SuperHero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHero.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Toy> Toys { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var hero = modelBuilder.Entity<Toy>();

        hero.HasKey(h => h.Id);

        hero.Property(h => h.Name).IsRequired().HasMaxLength(100);

        hero.Property(h => h.Alias).IsRequired().HasMaxLength(150);

        hero.Property(h => h.MainPower).IsRequired().HasMaxLength(150);

        hero.HasData(
    new Toy
    {
        Id = 1,
        Name = "Peter Parker",
        Alias = "Spider-Man",
        MainPower = "Spider-sense and agility",
        PowerLevel = 85,
        FirstAppearance = new DateOnly(1962, 8, 1)
    },
    new Toy
    {
        Id = 2,
        Name = "Carol Danvers",
        Alias = "Captain Marvel",
        MainPower = "Cosmic energy projection",
        PowerLevel = 95,
        FirstAppearance = new DateOnly(1968, 3, 1)
    },
    new Toy
    {
        Id = 3,
        Name = "Tony Stark",
        Alias = "Iron Man",
        MainPower = "Powered armor suit and genius intellect",
        PowerLevel = 90,
        FirstAppearance = new DateOnly(1963, 3, 1)
    },
    new Toy
    {
        Id = 4,
        Name = "Steve Rogers",
        Alias = "Captain America",
        MainPower = "Enhanced strength and tactical leadership",
        PowerLevel = 88,
        FirstAppearance = new DateOnly(1941, 3, 1)
    },
    new Toy
    {
        Id = 5,
        Name = "Natasha Romanoff",
        Alias = "Black Widow",
        MainPower = "Elite spy, martial arts and espionage",
        PowerLevel = 78,
        FirstAppearance = new DateOnly(1964, 4, 1)
    },
    new Toy
    {
        Id = 6,
        Name = "Thor Odinson",
        Alias = "Thor",
        MainPower = "God of thunder and Mjolnir",
        PowerLevel = 97,
        FirstAppearance = new DateOnly(1962, 8, 1)
    },
    new Toy
    {
        Id = 7,
        Name = "Bruce Banner",
        Alias = "Hulk",
        MainPower = "Limitless rage-fueled strength",
        PowerLevel = 96,
        FirstAppearance = new DateOnly(1962, 5, 1)
    },
    new Toy
    {
        Id = 8,
        Name = "T'Challa",
        Alias = "Black Panther",
        MainPower = "Enhanced abilities and vibranium suit",
        PowerLevel = 89,
        FirstAppearance = new DateOnly(1966, 7, 1)
    },
    new Toy
    {
        Id = 9,
        Name = "Stephen Strange",
        Alias = "Doctor Strange",
        MainPower = "Master of the mystic arts",
        PowerLevel = 93,
        FirstAppearance = new DateOnly(1963, 7, 1)
    },
    new Toy
    {
        Id = 10,
        Name = "Wanda Maximoff",
        Alias = "Scarlet Witch",
        MainPower = "Reality-warping chaos magic",
        PowerLevel = 98,
        FirstAppearance = new DateOnly(1964, 3, 1)
    },
    new Toy
    {
        Id = 11,
        Name = "Scott Lang",
        Alias = "Ant-Man",
        MainPower = "Size manipulation and tech expertise",
        PowerLevel = 80,
        FirstAppearance = new DateOnly(1979, 9, 1)
    },
    new Toy
    {
        Id = 12,
        Name = "Logan",
        Alias = "Wolverine",
        MainPower = "Regeneration and adamantium claws",
        PowerLevel = 92,
        FirstAppearance = new DateOnly(1974, 10, 1)
    },
    new Toy
    {
        Id = 13,
        Name = "Diana Prince",
        Alias = "Wonder Woman",
        MainPower = "Amazonian strength and lasso of truth",
        PowerLevel = 96,
        FirstAppearance = new DateOnly(1941, 12, 1)
    },
    new Toy
    {
        Id = 14,
        Name = "Barry Allen",
        Alias = "The Flash",
        MainPower = "Super speed and Speed Force",
        PowerLevel = 94,
        FirstAppearance = new DateOnly(1956, 10, 1)
    },
    new Toy
    {
        Id = 15,
        Name = "Arthur Curry",
        Alias = "Aquaman",
        MainPower = "Atlantean strength and control over the seas",
        PowerLevel = 88,
        FirstAppearance = new DateOnly(1941, 11, 1)
    }
     );
    }
}