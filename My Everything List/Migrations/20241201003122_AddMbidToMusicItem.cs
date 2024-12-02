using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyEverythingList.Migrations
{
    /// <inheritdoc />
    public partial class AddMbidToMusicItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "mbid",
                table: "music_items",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mbid",
                table: "music_items");
        }
    }
}
