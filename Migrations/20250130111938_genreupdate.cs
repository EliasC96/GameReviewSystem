using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewSystem.Migrations
{
    /// <inheritdoc />
    public partial class genreupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Game_GenreId",
                table: "Game",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_GenreId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Game");
        }
    }
}
