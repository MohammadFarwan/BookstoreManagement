using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bookstore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Aldous Huxley", "Dystopian", 9.99m, "Brave New World" },
                    { 2, "J.D. Salinger", "Fiction", 8.49m, "The Catcher in the Rye" },
                    { 3, "Jane Austen", "Romance", 6.99m, "Pride and Prejudice" },
                    { 4, "Herman Melville", "Adventure", 11.50m, "Moby Dick" },
                    { 5, "Paulo Coelho", "Philosophical", 9.49m, "The Alchemist" },
                    { 6, "Leo Tolstoy", "Historical Fiction", 12.99m, "War and Peace" },
                    { 7, "Ray Bradbury", "Dystopian", 7.49m, "Fahrenheit 451" },
                    { 8, "J.R.R. Tolkien", "Fantasy", 8.99m, "The Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
