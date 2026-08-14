using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpgGame.Migrations
{
    /// <inheritdoc />
    public partial class updateMonsterData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Element",
                table: "MonsterDatas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill4",
                table: "MonsterDatas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Skill5",
                table: "MonsterDatas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Element",
                table: "MonsterDatas");

            migrationBuilder.DropColumn(
                name: "Skill4",
                table: "MonsterDatas");

            migrationBuilder.DropColumn(
                name: "Skill5",
                table: "MonsterDatas");
        }
    }
}
