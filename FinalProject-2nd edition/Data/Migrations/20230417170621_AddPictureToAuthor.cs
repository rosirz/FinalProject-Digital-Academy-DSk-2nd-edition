using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_2nd_edition.Data.Migrations
{
    public partial class AddPictureToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Authors");
        }
    }
}
