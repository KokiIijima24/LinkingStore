using Microsoft.EntityFrameworkCore.Migrations;

namespace LinkingStore.GraphQL.Migrations
{
    public partial class UpdateLinkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Links_LinkId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.CreateTable(
                name: "LinkInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    Params = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkInfos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_LinkInfos_LinkId",
                table: "Messages",
                column: "LinkId",
                principalTable: "LinkInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_LinkInfos_LinkId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "LinkInfos");

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Params = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Links_LinkId",
                table: "Messages",
                column: "LinkId",
                principalTable: "Links",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
