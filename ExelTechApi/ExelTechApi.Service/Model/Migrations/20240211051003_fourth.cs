using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExelTechApi.Service.Model.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DiseaseInformation_DiseaseInformationDId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DiseaseInformationDId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DiseaseInformationDId",
                table: "Patients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiseaseInformationDId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DiseaseInformationDId",
                table: "Patients",
                column: "DiseaseInformationDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DiseaseInformation_DiseaseInformationDId",
                table: "Patients",
                column: "DiseaseInformationDId",
                principalTable: "DiseaseInformation",
                principalColumn: "DId");
        }
    }
}
