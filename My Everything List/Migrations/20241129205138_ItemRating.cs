using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEverythingList.Migrations
{
    /// <inheritdoc />
    public partial class ItemRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_music_music_items_SavedMusicId",
                table: "users_music");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users_music",
                table: "users_music");

            migrationBuilder.DropIndex(
                name: "IX_users_music_user_id_music_id",
                table: "users_music");

            migrationBuilder.DropIndex(
                name: "IX_users_films_user_id_film_id",
                table: "users_films");

            migrationBuilder.DropIndex(
                name: "IX_users_books_user_id_book_id",
                table: "users_books");

            migrationBuilder.RenameColumn(
                name: "SavedMusicId",
                table: "users_music",
                newName: "rating");

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "users_films",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "users_books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_music",
                table: "users_music",
                columns: new[] { "music_id", "user_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_music_user_id",
                table: "users_music",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_films_user_id",
                table: "users_films",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_books_user_id",
                table: "users_books",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_music_music_items_music_id",
                table: "users_music",
                column: "music_id",
                principalTable: "music_items",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_music_music_items_music_id",
                table: "users_music");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users_music",
                table: "users_music");

            migrationBuilder.DropIndex(
                name: "IX_users_music_user_id",
                table: "users_music");

            migrationBuilder.DropIndex(
                name: "IX_users_films_user_id",
                table: "users_films");

            migrationBuilder.DropIndex(
                name: "IX_users_books_user_id",
                table: "users_books");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "users_films");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "users_books");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "users_music",
                newName: "SavedMusicId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users_music",
                table: "users_music",
                columns: new[] { "SavedMusicId", "user_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_music_user_id_music_id",
                table: "users_music",
                columns: new[] { "user_id", "music_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_films_user_id_film_id",
                table: "users_films",
                columns: new[] { "user_id", "film_id" });

            migrationBuilder.CreateIndex(
                name: "IX_users_books_user_id_book_id",
                table: "users_books",
                columns: new[] { "user_id", "book_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_users_music_music_items_SavedMusicId",
                table: "users_music",
                column: "SavedMusicId",
                principalTable: "music_items",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
