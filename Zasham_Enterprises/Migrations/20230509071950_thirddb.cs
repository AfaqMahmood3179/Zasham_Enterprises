using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zasham_Enterprises.Migrations
{
    /// <inheritdoc />
    public partial class thirddb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productdescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productprice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productname);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
