using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEverythingList.Migrations
{
    /// <inheritdoc />
    public partial class UsersManyToManyItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users_books",
                columns: table => new
                {
                    SavedBooksId = table.Column<int>(type: "INTEGER", nullable: false),
                    SavedById = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_books", x => new { x.SavedBooksId, x.SavedById });
                    table.ForeignKey(
                        name: "FK_users_books_books_SavedBooksId",
                        column: x => x.SavedBooksId,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_books_users_SavedById",
                        column: x => x.SavedById,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_films",
                columns: table => new
                {
                    SavedById = table.Column<int>(type: "INTEGER", nullable: false),
                    SavedFilmsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_films", x => new { x.SavedById, x.SavedFilmsId });
                    table.ForeignKey(
                        name: "FK_users_films_film_SavedFilmsId",
                        column: x => x.SavedFilmsId,
                        principalTable: "film",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_films_users_SavedById",
                        column: x => x.SavedById,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_music",
                columns: table => new
                {
                    SavedById = table.Column<int>(type: "INTEGER", nullable: false),
                    SavedMusicId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_music", x => new { x.SavedById, x.SavedMusicId });
                    table.ForeignKey(
                        name: "FK_users_music_music_items_SavedMusicId",
                        column: x => x.SavedMusicId,
                        principalTable: "music_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_music_users_SavedById",
                        column: x => x.SavedById,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_books_SavedById",
                table: "users_books",
                column: "SavedById");

            migrationBuilder.CreateIndex(
                name: "IX_users_films_SavedFilmsId",
                table: "users_films",
                column: "SavedFilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_users_music_SavedMusicId",
                table: "users_music",
                column: "SavedMusicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users_books");

            migrationBuilder.DropTable(
                name: "users_films");

            migrationBuilder.DropTable(
                name: "users_music");
        }
    }
}
