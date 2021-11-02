using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Data.Migrations
{
    public partial class AddressMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "Products",
                newName: "MyAddress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Products",
                newName: "MyAddress_City");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Products",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyAddress_StreetAdress",
                table: "Products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "MyAddress_City",
                table: "Products",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "ImageName");
        }
    }
}
