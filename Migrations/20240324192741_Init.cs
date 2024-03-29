using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ogrodnik_lab2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dancerss",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    danceclass = table.Column<string>(type: "TEXT", nullable: true),
                    dancePartnerName = table.Column<string>(type: "TEXT", nullable: true),
                    danceClubName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dancerss", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Dancerss",
                columns: new[] { "id", "danceClubName", "dancePartnerName", "danceclass", "name" },
                values: new object[] { 20, "Wygibasy", "Dupson", "A", "Dupa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dancerss");
        }
    }
}
