using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewSystem.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Game",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Game_GenreId",
                table: "Game",
                newName: "IX_Game_GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Game",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_GenreID",
                table: "Game",
                newName: "IX_Game_GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
