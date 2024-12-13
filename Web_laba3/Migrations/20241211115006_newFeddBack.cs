using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_laba3.Migrations
{
    /// <inheritdoc />
    public partial class newFeddBack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "feedback",
                table: "Feedback",
                newName: "Theme");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Feedback",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Feedback",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "Theme",
                table: "Feedback",
                newName: "feedback");
        }
    }
}
