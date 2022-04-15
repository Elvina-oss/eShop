using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Migrations
{
    public partial class RemoveReleaseYearFromBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Brands");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Brands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
