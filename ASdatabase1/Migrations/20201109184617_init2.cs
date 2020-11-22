using Microsoft.EntityFrameworkCore.Migrations;

namespace ASdatabase.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdvertisementURL",
                table: "Ogloszenia",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Ogloszenia",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvertisementURL",
                table: "Ogloszenia");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Ogloszenia");
        }
    }
}
