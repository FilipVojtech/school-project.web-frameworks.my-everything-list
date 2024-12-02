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
            migrationBuilder.AlterColumn<string>(
                name: "genres",
                table: "film",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "users_books",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    book_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_books", x => new { x.book_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_users_books_books_book_id",
                        column: x => x.book_id,
                        principalTable: "books",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_books_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_films",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    film_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_films", x => new { x.film_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_users_films_film_film_id",
                        column: x => x.film_id,
                        principalTable: "film",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_films_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users_music",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    SavedMusicId = table.Column<int>(type: "INTEGER", nullable: false),
                    music_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users_music", x => new { x.SavedMusicId, x.user_id });
                    table.ForeignKey(
                        name: "FK_users_music_music_items_SavedMusicId",
                        column: x => x.SavedMusicId,
                        principalTable: "music_items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_music_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_books_user_id_book_id",
                table: "users_books",
                columns: new[] { "user_id", "book_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_films_user_id_film_id",
                table: "users_films",
                columns: new[] { "user_id", "film_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_music_user_id_music_id",
                table: "users_music",
                columns: new[] { "user_id", "music_id" });
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

            migrationBuilder.DropIndex(
                name: "IX_users_email",
                table: "users");

            migrationBuilder.AlterColumn<string>(
                name: "genres",
                table: "film",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
