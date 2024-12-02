using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEverythingList.Migrations
{
    /// <inheritdoc />
    public partial class AddAddedAtToUserItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "added_at",
                table: "users_music",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime()");

            migrationBuilder.AddColumn<DateTime>(
                name: "added_at",
                table: "users_films",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime()");

            migrationBuilder.AddColumn<DateTime>(
                name: "added_at",
                table: "users_books",
                type: "TEXT",
                nullable: false,
                defaultValueSql: "datetime()");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "added_at",
                table: "users_music");

            migrationBuilder.DropColumn(
                name: "added_at",
                table: "users_films");

            migrationBuilder.DropColumn(
                name: "added_at",
                table: "users_books");
        }
    }
}
