using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavoriteFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteFood",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteFood",
                table: "AspNetUsers");
        }
    }
}
