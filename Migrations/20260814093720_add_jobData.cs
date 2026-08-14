using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpgGame.Migrations
{
    /// <inheritdoc />
    public partial class add_jobData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobName = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Hp = table.Column<int>(type: "INTEGER", nullable: false),
                    Mp = table.Column<int>(type: "INTEGER", nullable: false),
                    Attack = table.Column<int>(type: "INTEGER", nullable: false),
                    Defense = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicAttack = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobDatas");
        }
    }
}
