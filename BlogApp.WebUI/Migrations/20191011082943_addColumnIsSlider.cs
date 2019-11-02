using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.WebUI.Migrations
{
    public partial class addColumnIsSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSlider",
                table: "Blogs",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSlider",
                table: "Blogs");
        }
    }
}
