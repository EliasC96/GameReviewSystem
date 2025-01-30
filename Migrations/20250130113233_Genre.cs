using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewSystem.Migrations
{
    /// <inheritdoc />
    public partial class Genre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Genre",
                newName: "GenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Genre",
                newName: "GenreId");
        }
    }
}
