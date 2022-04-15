using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Migrations
{
    public partial class RemoveImgFromCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryPictureURL",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryPictureURL",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
