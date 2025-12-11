using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperHero.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MainPower = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    FirstAppearance = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Alias", "FirstAppearance", "MainPower", "Name", "PowerLevel" },
                values: new object[,]
                {
                    { 1, "Spider-Man", new DateOnly(1962, 8, 1), "Spider-sense and agility", "Peter Parker", 85 },
                    { 2, "Captain Marvel", new DateOnly(1968, 3, 1), "Cosmic energy projection", "Carol Danvers", 95 },
                    { 3, "Iron Man", new DateOnly(1963, 3, 1), "Powered armor suit and genius intellect", "Tony Stark", 90 },
                    { 4, "Captain America", new DateOnly(1941, 3, 1), "Enhanced strength and tactical leadership", "Steve Rogers", 88 },
                    { 5, "Black Widow", new DateOnly(1964, 4, 1), "Elite spy, martial arts and espionage", "Natasha Romanoff", 78 },
                    { 6, "Thor", new DateOnly(1962, 8, 1), "God of thunder and Mjolnir", "Thor Odinson", 97 },
                    { 7, "Hulk", new DateOnly(1962, 5, 1), "Limitless rage-fueled strength", "Bruce Banner", 96 },
                    { 8, "Black Panther", new DateOnly(1966, 7, 1), "Enhanced abilities and vibranium suit", "T'Challa", 89 },
                    { 9, "Doctor Strange", new DateOnly(1963, 7, 1), "Master of the mystic arts", "Stephen Strange", 93 },
                    { 10, "Scarlet Witch", new DateOnly(1964, 3, 1), "Reality-warping chaos magic", "Wanda Maximoff", 98 },
                    { 11, "Ant-Man", new DateOnly(1979, 9, 1), "Size manipulation and tech expertise", "Scott Lang", 80 },
                    { 12, "Wolverine", new DateOnly(1974, 10, 1), "Regeneration and adamantium claws", "Logan", 92 },
                    { 13, "Wonder Woman", new DateOnly(1941, 12, 1), "Amazonian strength and lasso of truth", "Diana Prince", 96 },
                    { 14, "The Flash", new DateOnly(1956, 10, 1), "Super speed and Speed Force", "Barry Allen", 94 },
                    { 15, "Aquaman", new DateOnly(1941, 11, 1), "Atlantean strength and control over the seas", "Arthur Curry", 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toys");
        }
    }
}
