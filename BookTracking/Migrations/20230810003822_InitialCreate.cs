using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookTracking.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryTypes",
                columns: table => new
                {
                    Type = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    NameToken = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    CategoryType = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.NameToken);
                    table.ForeignKey(
                        name: "FK_Categories_CategoryTypes_CategoryType",
                        column: x => x.CategoryType,
                        principalTable: "CategoryTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Category_NameToken = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Author = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Categories_Category_NameToken",
                        column: x => x.Category_NameToken,
                        principalTable: "Categories",
                        principalColumn: "NameToken",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Category_NameToken",
                table: "Books",
                column: "Category_NameToken");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryType",
                table: "Categories",
                column: "CategoryType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryTypes");
        }
    }
}
