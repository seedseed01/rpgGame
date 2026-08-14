using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpgGame.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordToForum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "ForumMessages",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "ForumMessages");
        }
    }
}
