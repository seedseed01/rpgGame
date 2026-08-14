using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpgGame.Migrations
{
    /// <inheritdoc />
    public partial class add_NatureData_MonsterData_StatusData_EventsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventsDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Person = table.Column<string>(type: "TEXT", nullable: false),
                    Talk = table.Column<string>(type: "TEXT", nullable: false),
                    EventInfo = table.Column<string>(type: "TEXT", nullable: false),
                    Affect = table.Column<string>(type: "TEXT", nullable: false),
                    Porm = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonsterDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MonsterName = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Skill1 = table.Column<string>(type: "TEXT", nullable: false),
                    Skill2 = table.Column<string>(type: "TEXT", nullable: false),
                    Skill3 = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_MonsterDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NatureDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NatureName = table.Column<string>(type: "TEXT", nullable: false),
                    Ability = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusDatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventsDatas");

            migrationBuilder.DropTable(
                name: "MonsterDatas");

            migrationBuilder.DropTable(
                name: "NatureDatas");

            migrationBuilder.DropTable(
                name: "StatusDatas");
        }
    }
}
