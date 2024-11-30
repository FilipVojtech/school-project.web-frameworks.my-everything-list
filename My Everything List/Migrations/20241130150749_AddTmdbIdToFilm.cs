using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEverythingList.Migrations
{
    /// <inheritdoc />
    public partial class AddTmdbIdToFilm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "tmdb_id",
                table: "film",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tmdb_id",
                table: "film");
        }
    }
}
