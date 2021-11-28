using Microsoft.EntityFrameworkCore.Migrations;

namespace TPFinalLabo4.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "SuppliersProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SuppliersProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
