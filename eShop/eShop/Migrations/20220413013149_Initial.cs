using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfumePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerfumeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfumes_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category_Perfumes",
                columns: table => new
                {
                    PerfumeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Perfumes", x => new { x.CategoryId, x.PerfumeId });
                    table.ForeignKey(
                        name: "FK_Category_Perfumes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_Perfumes_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category_Perfumes_PerfumeId",
                table: "Category_Perfumes",
                column: "PerfumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_BrandId",
                table: "Perfumes",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category_Perfumes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Perfumes");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
