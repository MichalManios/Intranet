using Microsoft.EntityFrameworkCore.Migrations;

namespace ASdatabase.Migrations
{
    public partial class AddNewTableActualizationContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "ActualizationContent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    ZarzadzenieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActualizationContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActualizationContent_Zarzadzenia_ZarzadzenieId",
                        column: x => x.ZarzadzenieId,
                        principalTable: "Zarzadzenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActualizationContent_ZarzadzenieId",
                table: "ActualizationContent",
                column: "ZarzadzenieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActualizationContent");

           
        }
    }
}
