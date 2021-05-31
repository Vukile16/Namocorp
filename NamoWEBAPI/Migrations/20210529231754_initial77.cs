using Microsoft.EntityFrameworkCore.Migrations;

namespace NamoWEBAPI.Migrations
{
    public partial class initial77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactingType",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactingType",
                table: "Contacts");
        }
    }
}
