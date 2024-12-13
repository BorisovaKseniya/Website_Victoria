using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_laba3.Migrations
{
    /// <inheritdoc />
    public partial class changemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumb",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Route",
                table: "Tours",
                newName: "TourCategory");

            migrationBuilder.RenameColumn(
                name: "FullDescription",
                table: "Tours",
                newName: "LinkToFullDiscription");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TourCategory",
                table: "Tours",
                newName: "Route");

            migrationBuilder.RenameColumn(
                name: "LinkToFullDiscription",
                table: "Tours",
                newName: "FullDescription");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumb",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
