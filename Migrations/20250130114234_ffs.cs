using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewSystem.Migrations
{
    /// <inheritdoc />
    public partial class ffs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "Game",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Genid",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "Genid",
                table: "Game");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreID",
                table: "Game",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "GenreID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
