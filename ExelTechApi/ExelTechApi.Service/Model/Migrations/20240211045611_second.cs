using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExelTechApi.Service.Model.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DId",
                table: "Patients",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DId",
                table: "Patients");
        }
    }
}
